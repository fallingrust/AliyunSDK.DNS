using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Linq;

namespace AliyunSDK.DNS.Beans.Aliyun.Query
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 17:29:19
    /// </summary>
    public class GetTxtRecordForVerifyQuery : AliyunQueryBase
    {
        public GetTxtRecordForVerifyQuery(string domainName,string type,string accessKeyId, string action = "GetTxtRecordForVerify") : base(accessKeyId, action)
        {
            DomainName = domainName;
            Type = type;
        }

        public string DomainName { get; set; }

        public string Type { get; set; }
        public override Dictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("DomainName", DomainName);
            dic.Add("Type", Type);
            return dic.OrderBy(p => p.Key, new OrdinalComparer()).ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
