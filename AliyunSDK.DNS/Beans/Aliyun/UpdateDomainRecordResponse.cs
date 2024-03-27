using AliyunSDK.DNS.Beans.Base;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AliyunDns.Core.Beans.Aliyun
{
    public class UpdateDomainRecordResponse : AliyunResponseBase
    {
        public string? RecordId { get; set; }
    }

    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(UpdateDomainRecordResponse))]
    [JsonSerializable(typeof(IEnumerable<UpdateDomainRecordResponse>))]
    public partial class UpdateDomainRecordResponseSerializerContext : JsonSerializerContext
    {
    }

}
