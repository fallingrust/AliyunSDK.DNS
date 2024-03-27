using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(GetTxtRecordForVerifyResponse))]
    [JsonSerializable(typeof(IEnumerable<GetTxtRecordForVerifyResponse>))]
    public partial class GetTxtRecordForVerifyResponseSerializerContext : JsonSerializerContext
    {
    }
}
