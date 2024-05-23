using AliyunSDK.DNS.Beans.Base;

#if NET6_0_OR_GREATER
using System.Text.Json.Serialization;
using System.Collections.Generic;
#endif

namespace AliyunDns.Core.Beans.Aliyun
{
    public class UpdateDomainRecordResponse : AliyunResponseBase
    {
        public string? RecordId { get; set; }
    }
#if NET6_0_OR_GREATER
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(UpdateDomainRecordResponse))]
    [JsonSerializable(typeof(IEnumerable<UpdateDomainRecordResponse>))]
    public partial class UpdateDomainRecordResponseSerializerContext : JsonSerializerContext
    {
    }
#endif
}
