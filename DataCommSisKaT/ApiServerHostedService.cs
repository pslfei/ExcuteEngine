
using EngineCore.Models;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;
using TDServer.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Reflection;

public class ApiServerHostedService : IHostedService
{
    private readonly IInitServer _initServer;
    private readonly ConfigInfo _configInfo;
    // ExcuteEngine 可能在构造函数之后不会被直接使用，
    // 但通过在这里注入它，可以确保它的实例在服务启动前被创建。
    private readonly ExcuteEngine _excuteEngine;
    private Task? _serverTask;
    private readonly CancellationTokenSource _cancellationTokenSource = new();

    public ApiServerHostedService(
        IInitServer initServer,
        ConfigInfo configInfo,
        ExcuteEngine excuteEngine)
    {
        _initServer = initServer;
        _configInfo = configInfo;
        _excuteEngine = excuteEngine;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("=== ApiServerHostedService.StartAsync 开始执行 ===");

        // 在后台线程启动Web服务器，避免阻塞主线程
        _serverTask = Task.Run(() =>
        {
            try
            {
                // 此时，可以保证 _excuteEngine 已经被实例化
                _initServer.Init(_configInfo.rtserverport);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API服务器启动时发生错误: {ex.Message}");
            }
        }, cancellationToken);

        Console.WriteLine($"API服务器已在后台启动，端口: {_configInfo.rtserverport}");
        return Task.CompletedTask;
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("正在停止API服务器...");
        _cancellationTokenSource.Cancel();

        if (_serverTask != null)
        {
            await _serverTask;
        }

        Console.WriteLine("API服务器已停止");
    }
}