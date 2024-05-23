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
    /// date：2024/3/27 14:35:26
    /// </summary>
    public class AddDomainRecordResponse : AliyunResponseBase
    {
        public string? RecordId { get; set; }
    }
#if NET6_0_OR_GREATER
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(AddDomainRecordResponse))]
    [JsonSerializable(typeof(IEnumerable<AddDomainRecordResponse>))]
    public partial class AddDomainRecordResponseSerializerContext : JsonSerializerContext
    {
    }
#endif
}
