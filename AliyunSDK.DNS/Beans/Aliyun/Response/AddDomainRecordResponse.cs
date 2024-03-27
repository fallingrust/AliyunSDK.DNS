using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AliyunSDK.DNS.Beans.Aliyun
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 14:35:26
    /// </summary>
    public class AddDomainRecordResponse : AliyunResponseBase
    {
        public string? RecordId { get; set; }
    }
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(AddDomainRecordResponse))]
    [JsonSerializable(typeof(IEnumerable<AddDomainRecordResponse>))]
    public partial class AddDomainRecordResponseSerializerContext : JsonSerializerContext
    {
    }
}
