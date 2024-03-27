using AliyunSDK.DNS.Beans.Base;
using System.Collections.Generic;

namespace AliyunSDK.DNS.Beans.Aliyun
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 14:47:30
    /// </summary>
    public class DeleteDomainRecordQuery : AliyunQueryBase
    {
        public DeleteDomainRecordQuery(string recordId, string accessKeyId, string action = "DeleteDomainRecord") : base(accessKeyId, action)
        {
            RecordId = recordId;
        }
        public string RecordId { get; set; }

        public override SortedDictionary<string, string> GetQuery()
        {
            var dic = GetParamsDictionary();
            dic.Add("RecordId", RecordId);           
            return dic;
        }
    }
}
