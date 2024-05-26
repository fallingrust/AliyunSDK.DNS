using AliyunSDK.DNS.Beans.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliyunSDK.DNS.Beans.Aliyun.Query
{
    public class UpdateDomainRecordQuery : AliyunQueryBase
    {

        public UpdateDomainRecordQuery(string recordId, string rr, string type, string value, string accessKeyId, string action = "UpdateDomainRecord") : base(accessKeyId, action)
        {
            RecordId = recordId;
            RR = rr;
            Type = type;
            Value = value;
        }
        public string RecordId { get; set; } = "";
        public string RR { get; set; } = "";
        public string Type { get; set; } = "";
        public string Value { get; set; } = "";

        public override Dictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("RecordId", RecordId);
            dic.Add("RR", RR);
            dic.Add("Type", Type);
            dic.Add("Value", Value);
            return dic.OrderBy(p => p.Key, new OrdinalComparer()).ToDictionary(x => x.Key, y => y.Value);
        }
    }

    public class OrdinalComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.CompareOrdinal(x, y);
        }
    }
}
