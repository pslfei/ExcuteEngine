using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;


public static class TpriClient
{
    private static readonly string FixedAssetCode =
        Environment.GetEnvironmentVariable("TPRI_FIXED_ASSET_CODE") ?? "opc_jianpan";
    private static readonly string AccessKey = GetRequiredEnvironmentVariable("TPRI_ACCESS_KEY");
    private static readonly string SecretKey = GetRequiredEnvironmentVariable("TPRI_SECRET_KEY");
    private static readonly string BaseUrl =
        GetRequiredEnvironmentVariable("TPRI_BASE_URL").TrimEnd('/');

    private static readonly HttpClient _httpClient;

    static TpriClient()
    {
        var clientHandler = new HttpClientHandler
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
        };
        _httpClient = new HttpClient(clientHandler);
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("PostmanRuntime-ApipostRuntime/1.1.0");
    }

    private static string GetRequiredEnvironmentVariable(string name)
    {
        string? value = Environment.GetEnvironmentVariable(name);
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidOperationException($"缺少必需的环境变量：{name}");
        }

        return value;
    }

    // 对外公开的批量写入方法：只需要传入属性列表（编码+值）和时间
    public static async Task<int> BatchWriteValuesAsync(List<AttributeItem> attributes, DateTime time)
    {
        // 构建请求URL（批量接口）
        string url = $"{BaseUrl}/2021-06-10/attributes";
        // 生成请求体（自动包含固定的资产编码）
        string requestBody = GenerateBatchRequestBody(attributes);
        return await SendBatchRequestAsync(url, HttpMethod.Patch, requestBody, time);
    }

    // 生成请求体：自动将固定资产编码和属性列表组合
    private static string GenerateBatchRequestBody(List<AttributeItem> attributes)
    {
        // 固定一个资产，包含传入的所有属性
        var requestData = new List<object>
            {
                new
                {
                    AssetCode = FixedAssetCode, // 固定资产编码
                    Attributes = attributes.Select(a => new { Code = a.Code, Value = a.Value }).ToList()
                }
            };
        return JsonConvert.SerializeObject(requestData);
    }

    // 发送请求的逻辑（与之前类似）
    private static async Task<int> SendBatchRequestAsync(string url, HttpMethod method, string body, DateTime time)
    {
        var request = new HttpRequestMessage
        {
            Method = method,
            RequestUri = new Uri(url),
            Headers =
                {
                    { "X-Ca-Key", AccessKey },
                    { "X-Ca-Signature-Headers", "X-Ca-Key" },
                    { "X-Ca-Signature", AddBatchSignature(body, time) },
                    { "Date", time.ToString("r", System.Globalization.CultureInfo.InvariantCulture) },
                    { "Connection", "keep-alive" },
                },
            Content = new StringContent(body)
            {
                Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
            }
        };

        using (var response = await _httpClient.SendAsync(request))
        {
            var responseBody = await response.Content.ReadAsStringAsync();
            return response.IsSuccessStatusCode ? 200 : (int)response.StatusCode;
        }
    }

    private static string AddBatchSignature(string body, DateTime time)
    {
        string bodyMd5 = ComputeMd5(body);
        string dateStr = time.ToString("r", System.Globalization.CultureInfo.InvariantCulture);

        string mustSign =
            $"{HttpMethod.Patch}\n" +
            "application/json\n" +
            $"{bodyMd5}\n" +
            "application/json\n" +
            $"{dateStr}\n" +
            $"{AccessKey}";

        return ComputeHmacSha256Base64(mustSign, SecretKey);
    }

    private static string ComputeMd5(string input)
    {
        using (var md5 = MD5.Create())
        {
            byte[] bs = Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(bs);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }

    private static string ComputeHmacSha256Base64(string message, string secret)
    {
        using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret)))
        {
            byte[] sig = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
            return Convert.ToBase64String(sig);
        }
    }
}

public class AttributeItem
{
    public string Code { get; set; } // 属性编码（点名）
    public string Value { get; set; } // 属性值（数值）
}
