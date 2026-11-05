using System.Collections.Concurrent;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// 仅监听操作系统分配的本机端口，不读取 Config.json，不访问现场服务。
internal sealed class FakeServer : IAsyncDisposable
{
    private readonly WebApplication app;
    public string Url { get; }
    public ConcurrentQueue<CapturedRequest> Requests { get; } = new();
    public ConcurrentQueue<Reply> Replies { get; } = new();
    public Reply DefaultReply { get; set; } = new();

    private FakeServer(WebApplication app, string url)
    {
        this.app = app;
        Url = url;
    }

    public static async Task<FakeServer> Start()
    {
        var builder = WebApplication.CreateBuilder();
        builder.Logging.ClearProviders();
        builder.WebHost.UseUrls("http://127.0.0.1:0");
        var app = builder.Build();
        FakeServer? server = null;
        app.Run(async context =>
        {
            string body;
            using (var reader = new StreamReader(context.Request.Body, Encoding.UTF8))
                body = await reader.ReadToEndAsync();
            server!.Requests.Enqueue(new CapturedRequest(context.Request.Method,
                context.Request.Path, context.Request.QueryString.Value ?? "",
                context.Request.ContentType ?? "", context.Request.Headers.Authorization.ToString(), body));
            Reply reply = server.Replies.TryDequeue(out var queued) ? queued : server.DefaultReply;
            context.Response.StatusCode = reply.Status;
            context.Response.ContentType = "application/json";
            context.Response.Headers["X-Request-Id"] = "local-test-trace";
            if (reply.Location != null) context.Response.Headers.Location = reply.Location;
            try
            {
                if (reply.DelayHeadersMs > 0)
                    await Task.Delay(reply.DelayHeadersMs, context.RequestAborted);
                await context.Response.StartAsync(context.RequestAborted);
                if (reply.DelayBodyMs > 0)
                    await Task.Delay(reply.DelayBodyMs, context.RequestAborted);
                await context.Response.WriteAsync(reply.Body, context.RequestAborted);
            }
            catch (OperationCanceledException) when (context.RequestAborted.IsCancellationRequested) { }
        });
        await app.StartAsync();
        string address = app.Services.GetRequiredService<IServer>().Features
            .Get<IServerAddressesFeature>()!.Addresses.Single();
        server = new FakeServer(app, address);
        return server;
    }

    public async ValueTask DisposeAsync()
    {
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        await app.StopAsync(timeout.Token);
        await app.DisposeAsync();
    }
}

internal sealed record CapturedRequest(string Method, string Path, string Query,
    string ContentType, string Authorization, string Body);

internal sealed class Reply
{
    public int Status { get; init; } = 200;
    public string Body { get; init; } = "{\"code\":0,\"msg\":\"success\",\"data\":[]}";
    public int DelayHeadersMs { get; init; }
    public int DelayBodyMs { get; init; }
    public string? Location { get; init; }
}
