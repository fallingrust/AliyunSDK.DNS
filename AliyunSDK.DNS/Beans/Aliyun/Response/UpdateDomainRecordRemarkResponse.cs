using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AliyunSDK.DNS.Beans.Aliyun.Response
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 16:46:41
    /// </summary>
    public class UpdateDomainRecordRemarkResponse : AliyunResponseBase
    {
    }
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(UpdateDomainRecordRemarkResponse))]
    [JsonSerializable(typeof(IEnumerable<UpdateDomainRecordRemarkResponse>))]
    public partial class UpdateDomainRecordRemarkResponseSerializerContext : JsonSerializerContext
    {
    }
}
