using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Linq;

namespace AliyunSDK.DNS.Beans.Aliyun.Query
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 14:35:14
    /// </summary>
    public class AddDomainRecordQuery : AliyunQueryBase
    {
        public AddDomainRecordQuery(string domainName, string rr, string type, string value, string accessKeyId, string action = "AddDomainRecord") : base(accessKeyId, action)
        {
            DomainName = domainName;
            RR = rr;
            Type = type;
            Value = value;
        }

        public string DomainName { get; set; }
        public string RR { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public override Dictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("DomainName", DomainName);
            dic.Add("RR", RR);
            dic.Add("Type", Type);
            dic.Add("Value", Value);
            return dic.OrderBy(p => p.Key, new OrdinalComparer()).ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
