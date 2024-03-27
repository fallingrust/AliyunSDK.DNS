using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace AliyunDns.Core.Beans.Aliyun
{
    public class Record
    {
        public long CreateTimestamp { get; set; }

        public string? DomainName { get; set; }

        public string? Line { get; set; }

        public bool Locked { get; set; }

        public string? RR { get; set; }

        public string? RecordId { get; set; }

        public string? Status { get; set; }

        public int TTL { get; set; }

        public string? Type { get; set; }

        public long UpdateTimestamp { get; set; }

        public string? Value { get; set; }

        public int Weight { get; set; }
    }   
    public class DomainRecords
    {

        public List<Record>? Record { get; set; }
    }  
    public class DescribeDomainRecordsResponse : AliyunResponseBase
    {
        public DomainRecords? DomainRecords { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }       

        public int TotalCount { get; set; }
    }

    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(DescribeDomainRecordsResponse))]
    [JsonSerializable(typeof(IEnumerable<DescribeDomainRecordsResponse>))]
    public partial class DescribeDomainRecordsResponseSerializerContext : JsonSerializerContext
    {
    }

    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(DomainRecords))]
    [JsonSerializable(typeof(IEnumerable<DomainRecords>))]
    public partial class DomainRecordsSerializerContext : JsonSerializerContext
    {
    }

    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(Record))]
    [JsonSerializable(typeof(IEnumerable<Record>))]
    public partial class RecordSerializerContext : JsonSerializerContext
    {
    }
}
