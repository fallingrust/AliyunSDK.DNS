using System;
using System.Collections.Generic;

namespace AliyunSDK.DNS.Beans.Base
{
    public abstract class AliyunQueryBase
    {
        public AliyunQueryBase(string accessKeyId, string action)
        {
            AccessKeyId = accessKeyId;
            Action = action;
        }
        public string Action { get; set; }
        public string Version { get; set; } = "2015-01-09";
        public string Format { get; set; } = "JSON";
        public string AccessKeyId { get; set; }
        public string SignatureNonce { get; set; } = Guid.NewGuid().ToString("N");
        public string Timestamp { get; set; } = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
        public string SignatureMethod { get; set; } = "HMAC-SHA1";
        public string SignatureVersion { get; set; } = "1.0";

        public abstract SortedDictionary<string, string> GetQuery();
       
        protected SortedDictionary<string,string> GetParamsDictionary()
        {
            return new SortedDictionary<string, string>()
            {
                { "Action", Action },
                { "Version", Version },
                { "Format", Format },
                { "AccessKeyId", AccessKeyId },
                { "SignatureNonce", SignatureNonce },
                { "Timestamp", Timestamp },
                { "SignatureMethod", SignatureMethod },
                { "SignatureVersion", SignatureVersion },                
            };
        }
    }
}
