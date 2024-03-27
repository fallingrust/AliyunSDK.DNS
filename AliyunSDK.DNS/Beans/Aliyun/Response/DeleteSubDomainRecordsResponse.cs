using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AliyunSDK.DNS.Beans.Aliyun
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 14:55:20
    /// </summary>
    public class DeleteSubDomainRecordsResponse : AliyunResponseBase
    {
        public string? RR { get; set; }
        public string? TotalCount { get; set; }
    }
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(DeleteSubDomainRecordsResponse))]
    [JsonSerializable(typeof(IEnumerable<DeleteSubDomainRecordsResponse>))]
    public partial class DeleteSubDomainRecordsResponseSerializerContext : JsonSerializerContext
    {
    }
}
