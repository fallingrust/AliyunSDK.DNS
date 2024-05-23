#if NET6_0_OR_GREATER
using System.Text.Json.Serialization;
using System.Collections.Generic;
#endif
namespace AliyunSDK.DNS.Beans.Base
{
    public abstract class AliyunResponseBase
    {
        public string? RequestId { get; set; }
    }
#if NET6_0_OR_GREATER
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(AliyunResponseBase))]
    [JsonSerializable(typeof(IEnumerable<AliyunResponseBase>))]
    public partial class AliyunResponseBaseSerializerContext : JsonSerializerContext
    {
    }
#endif
}
