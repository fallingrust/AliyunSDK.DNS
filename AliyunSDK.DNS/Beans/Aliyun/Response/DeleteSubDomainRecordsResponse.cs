using AliyunSDK.DNS.Beans.Base;
#if NET6_0_OR_GREATER
using System.Text.Json.Serialization;
using System.Collections.Generic;
#endif

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
#if NET6_0_OR_GREATER
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(DeleteSubDomainRecordsResponse))]
    [JsonSerializable(typeof(IEnumerable<DeleteSubDomainRecordsResponse>))]
    public partial class DeleteSubDomainRecordsResponseSerializerContext : JsonSerializerContext
    {
    }
#endif
}
