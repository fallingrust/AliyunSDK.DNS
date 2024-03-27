using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace AliyunSDK.DNS.Beans.Base
{
    public abstract class AliyunResponseBase
    {
        public string? RequestId { get; set; }
    }
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(AliyunResponseBase))]
    [JsonSerializable(typeof(IEnumerable<AliyunResponseBase>))]
    public partial class AliyunResponseBaseSerializerContext : JsonSerializerContext
    {
    }
}
