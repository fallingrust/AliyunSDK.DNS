using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Linq;

namespace AliyunSDK.DNS.Beans.Aliyun.Query
{
    public class DescribeDomainRecordsQuery : AliyunQueryBase
    {
        public DescribeDomainRecordsQuery(string domainName, string accessKeyId, string action = "DescribeDomainRecords") : base(accessKeyId, action)
        {
            DomainName = domainName;
        }
        public string DomainName { get; set; }

        public long PageNumber { get; set; } = 1;

        public long PageSize { get; set; } = 100;
        public override Dictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("DomainName", DomainName);
            dic.Add("PageNumber", PageNumber.ToString());
            dic.Add("PageSize", PageSize.ToString());
            return dic.OrderBy(p => p.Key, new OrdinalComparer()).ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
