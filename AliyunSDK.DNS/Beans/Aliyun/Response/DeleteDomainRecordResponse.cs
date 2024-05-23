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
    /// date：2024/3/27 14:47:42
    /// </summary>
    public class DeleteDomainRecordResponse: AliyunResponseBase
    {
        public string? RecordId { get; set; }
    }
#if NET6_0_OR_GREATER
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(DeleteDomainRecordResponse))]
    [JsonSerializable(typeof(IEnumerable<DeleteDomainRecordResponse>))]
    public partial class DeleteDomainRecordResponseSerializerContext : JsonSerializerContext
    {
    }
#endif
}
