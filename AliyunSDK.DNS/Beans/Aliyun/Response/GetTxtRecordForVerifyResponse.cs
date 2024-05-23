using AliyunSDK.DNS.Beans.Base;
#if NET6_0_OR_GREATER
using System.Text.Json.Serialization;
using System.Collections.Generic;
#endif

namespace AliyunSDK.DNS.Beans.Aliyun.Response
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 17:31:59
    /// </summary>
    public class GetTxtRecordForVerifyResponse : AliyunResponseBase
    {
        public string? RR { get; set; }
        public string? DomainName { get; set; }
        public string? Value { get; set; }
    }
#if NET6_0_OR_GREATER
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(GetTxtRecordForVerifyResponse))]
    [JsonSerializable(typeof(IEnumerable<GetTxtRecordForVerifyResponse>))]
    public partial class GetTxtRecordForVerifyResponseSerializerContext : JsonSerializerContext
    {
    }
#endif
}
