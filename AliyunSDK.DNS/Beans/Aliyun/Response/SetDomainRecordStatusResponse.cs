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
    /// date：2024/3/27 17:07:31
    /// </summary>
    public class SetDomainRecordStatusResponse : AliyunResponseBase
    {
        public string? Status { get; set; }
        public string? RecordId { get; set; }      
    }
#if NET6_0_OR_GREATER
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(SetDomainRecordStatusResponse))]
    [JsonSerializable(typeof(IEnumerable<SetDomainRecordStatusResponse>))]
    public partial class SetDomainRecordStatusResponseSerializerContext : JsonSerializerContext
    {
    }
#endif
}
