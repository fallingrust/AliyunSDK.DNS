﻿using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
#if NET6_0_OR_GREATER
using System.Text.Json.Serialization;
#endif

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

        public long TTL { get; set; }

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

        public long PageNumber { get; set; }

        public long PageSize { get; set; }       

        public long TotalCount { get; set; }
    }
#if NET6_0_OR_GREATER
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
#endif
}
