using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AliyunDns.Core.Beans.Aliyun
{
    public class SubRecord
    {
        public string? Status { get; set; }
        public string? Type { get; set; }
        public int Weight { get; set; }
        public string? Value { get; set; }
        public int TTL { get; set; }
        public string? Line { get; set; }
        public string? RecordId { get; set; }
        public int Priority { get; set; }
        public string? RR { get; set; }
        public string? DomainName { get; set; }
        public bool Locked { get; set; }
        public string? Remark { get; set; }
    }
    public class SubDomainRecords
    {

        public List<Record>? Record { get; set; }
    }
    public class DescribeSubDomainRecordsResponse : AliyunResponseBase
    {
        public DomainRecords? DomainRecords { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }
    }
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(DescribeSubDomainRecordsResponse))]
    [JsonSerializable(typeof(IEnumerable<DescribeSubDomainRecordsResponse>))]
    public partial class DescribeSubDomainRecordsResponseSerializerContext : JsonSerializerContext
    {
    }

    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(SubDomainRecords))]
    [JsonSerializable(typeof(IEnumerable<SubDomainRecords>))]
    public partial class SubDomainRecordsSerializerContext : JsonSerializerContext
    {
    }

    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(SubRecord))]
    [JsonSerializable(typeof(IEnumerable<SubRecord>))]
    public partial class SubRecordSerializerContext : JsonSerializerContext
    {
    }
}
