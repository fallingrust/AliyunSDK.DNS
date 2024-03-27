using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(DeleteDomainRecordResponse))]
    [JsonSerializable(typeof(IEnumerable<DeleteDomainRecordResponse>))]
    public partial class DeleteDomainRecordResponseSerializerContext : JsonSerializerContext
    {
    }
}
