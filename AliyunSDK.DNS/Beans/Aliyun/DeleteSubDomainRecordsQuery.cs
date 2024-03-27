using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;

namespace AliyunSDK.DNS.Beans.Aliyun
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 14:55:08
    /// </summary>
    public class DeleteSubDomainRecordsQuery : AliyunQueryBase
    {
        public DeleteSubDomainRecordsQuery(string domainName,string rr,string recordType,string accessKeyId, string action = "DeleteSubDomainRecords") : base(accessKeyId, action)
        {
            DomainName = domainName;
            RR = rr;
            RecordType = recordType;
        }
        public string DomainName { get; set; }
        public string RR { get; set; }
        public string RecordType {  get; set; }
        public override SortedDictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("DomainName", DomainName);
            dic.Add("RR", RR);
            dic.Add("Type", RecordType);
            return dic;
        }
    }
}
