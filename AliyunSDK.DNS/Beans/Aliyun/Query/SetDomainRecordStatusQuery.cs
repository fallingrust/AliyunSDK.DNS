using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;
using System.Linq;

namespace AliyunSDK.DNS.Beans.Aliyun.Query
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 17:03:27
    /// </summary>
    public class SetDomainRecordStatusQuery : AliyunQueryBase
    {
        public SetDomainRecordStatusQuery(string recordd,string status, string accessKeyId, string action = "SetDomainRecordStatus") : base(accessKeyId, action)
        {
            RecordId = recordd;
            Status = status;
        }
        public string RecordId { get; set; }
        public string Status { get; set; }

        public override Dictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("RecordId", RecordId);
            dic.Add("Status", Status);
            return dic.OrderBy(p => p.Key, new OrdinalComparer()).ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
