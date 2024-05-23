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
    /// date：2024/3/27 16:46:41
    /// </summary>
    public class UpdateDomainRecordRemarkResponse : AliyunResponseBase
    {
    }
#if NET6_0_OR_GREATER
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(UpdateDomainRecordRemarkResponse))]
    [JsonSerializable(typeof(IEnumerable<UpdateDomainRecordRemarkResponse>))]
    public partial class UpdateDomainRecordRemarkResponseSerializerContext : JsonSerializerContext
    {
    }
#endif
}
