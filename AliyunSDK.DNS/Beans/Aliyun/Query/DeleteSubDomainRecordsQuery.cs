using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;

namespace AliyunSDK.DNS.Beans.Aliyun.Query
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 14:55:08
    /// </summary>
    public class DeleteSubDomainRecordsQuery : AliyunQueryBase
    {
        public DeleteSubDomainRecordsQuery(string domainName, string rr, string type, string accessKeyId, string action = "DeleteSubDomainRecords") : base(accessKeyId, action)
        {
            DomainName = domainName;
            RR = rr;
            Type = type;
        }
        public string DomainName { get; set; }
        public string RR { get; set; }
        public string Type { get; set; }
        public override SortedDictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("DomainName", DomainName);
            dic.Add("RR", RR);
            dic.Add("Type", Type);
            return dic;
        }
    }
}
