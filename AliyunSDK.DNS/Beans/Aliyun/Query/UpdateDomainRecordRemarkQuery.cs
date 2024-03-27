using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;

namespace AliyunSDK.DNS.Beans.Aliyun.Query
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 16:45:06
    /// </summary>
    public class UpdateDomainRecordRemarkQuery : AliyunQueryBase
    {
        public UpdateDomainRecordRemarkQuery(string recordId, string remark, string accessKeyId, string action = "UpdateDomainRecordRemark") : base(accessKeyId, action)
        {
            RecordId = recordId;
            Remark = remark;
        }
        public string RecordId { get; set; }
        public string Remark { get; set; }
        public override SortedDictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("RecordId", RecordId);
            dic.Add("Remark", Remark);
            return dic;
        }
    }
}
