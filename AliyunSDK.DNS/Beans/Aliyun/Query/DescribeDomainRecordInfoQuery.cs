﻿using AliyunSDK.DNS.Beans.Base;
using System;
using System.Collections.Generic;

namespace AliyunSDK.DNS.Beans.Aliyun.Query
{
    /// <summary>
    /// describe：
    /// author：cxj
    /// date：2024/3/27 17:24:49
    /// </summary>
    public class DescribeDomainRecordInfoQuery : AliyunQueryBase
    {
        public DescribeDomainRecordInfoQuery(string recordId, string accessKeyId, string action = "DescribeDomainRecordInfo") : base(accessKeyId, action)
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
