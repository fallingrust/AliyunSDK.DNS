using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AliyunSDK.DNS.Beans.Aliyun.Response
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 17:26:06
    /// </summary>
    public class DescribeDomainRecordInfoResponse : AliyunResponseBase
    {
        public string? Status { get; set; }
       
        public string? RR { get; set; }
       
        public string? GroupName { get; set; }
       
        public string? DomainName { get; set; }
       
        public long Priority { get; set; }
       
        public string? PunyCode { get; set; }
      
        public long TTL { get; set; }
      
        public string? GroupId { get; set; }
        
        public string? Line { get; set; }
     
        public bool Locked { get; set; }
       
        public string? Type { get; set; }
     
        public string? DomainId { get; set; }
      
        public string? Value { get; set; }
      
        public string? RecordId { get; set; }
      
        public string? Remark { get; set; }
    }
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(DescribeDomainRecordInfoResponse))]
    [JsonSerializable(typeof(IEnumerable<DescribeDomainRecordInfoResponse>))]
    public partial class DescribeDomainRecordInfoResponseSerializerContext : JsonSerializerContext
    {
    }
}
