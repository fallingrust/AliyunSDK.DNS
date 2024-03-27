using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;

namespace AliyunSDK.DNS.Beans.Aliyun
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 14:35:14
    /// </summary>
    public class AddDomainRecordQuery : AliyunQueryBase
    {
        public AddDomainRecordQuery(string domainName, string rr, string recordType, string value, string accessKeyId, string action = "AddDomainRecord") : base(accessKeyId, action)
        {
            DomainName = domainName;
            RR = rr;
            RecordType = recordType;
            Value = value;
        }

        public string DomainName { get; set; }
        public string RR { get; set; }
        public string RecordType { get; set; }
        public string Value { get; set; }
        public override SortedDictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("DomainName", DomainName);
            dic.Add("RR", RR);
            dic.Add("Type", RecordType);
            dic.Add("Value", Value);
            return dic;
        }
    }
}
