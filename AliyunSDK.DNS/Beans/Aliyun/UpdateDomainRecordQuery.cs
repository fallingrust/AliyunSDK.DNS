using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;

namespace AliyunSDK.DNS.Beans.Aliyun
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

        public override SortedDictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("RecordId", RecordId);
            dic.Add("RR", RR);
            dic.Add("Type", Type);
            dic.Add("Value", Value);
            return dic;
        }
    }
}
