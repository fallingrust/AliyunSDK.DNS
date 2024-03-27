using AliyunDns.Core;
using AliyunDns.Core.Beans.Aliyun;
using AliyunSDK.DNS.Beans.Aliyun;
using AliyunSDK.DNS.Beans.Aliyun.Query;
using AliyunSDK.DNS.Beans.Base;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace AliyunSDK.DNS
{
    public class AliyunDNS
    {
        private static HttpClient? _client;
        private static Option? _option;
        public static void Configure(Option option)
        {
            _option = option;
            _client = new HttpClient
            {
                BaseAddress = new Uri(_option.EndPoint)
            };
        }

        public static async Task<DescribeDomainRecordsResponse?> DescribeDomainRecordsAsync(string domain)
        {
            if (_option == null) return null;
            return await GetAsync(new DescribeDomainRecordsQuery(domain, _option.KeyId), DescribeDomainRecordsResponseSerializerContext.Default.DescribeDomainRecordsResponse);
        }

        public static async Task<DescribeSubDomainRecordsResponse?> DescribeSubDomainRecordsAsync(string subDomainName)
        {
            if (_option == null) return null;
            return await GetAsync(new DescribeSubDomainRecordsQuery(subDomainName, _option.KeyId), DescribeSubDomainRecordsResponseSerializerContext.Default.DescribeSubDomainRecordsResponse);
        }

        public static async Task<UpdateDomainRecordResponse?> UpdateDomainRecordAsync(Record record, string value)
        {
            if (_option == null) return null;
            if (record == null) return null;
            if (string.IsNullOrEmpty(record.RecordId) || string.IsNullOrEmpty(record.RR) || string.IsNullOrEmpty(record.Type)) return null;
            var query = new UpdateDomainRecordQuery(record.RecordId, record.RR, record.Type, value, _option.KeyId);
            return await GetAsync(query, UpdateDomainRecordResponseSerializerContext.Default.UpdateDomainRecordResponse);
        }

        public static async Task<AddDomainRecordResponse?> AddDomainRecordAsync(string domain, string rr, string recordType, string value)
        {
            if (_option == null) return null;
            var query = new AddDomainRecordQuery(domain, rr, recordType, value, _option.KeyId);
            return await GetAsync(query, AddDomainRecordResponseSerializerContext.Default.AddDomainRecordResponse);
        }

        public static async Task<DeleteDomainRecordResponse?> DeleteDomainRecordAsync(string recordId)
        {
            if (_option == null) return null;
            var query = new DeleteDomainRecordQuery(recordId, _option.KeyId);
            return await GetAsync(query, DeleteDomainRecordResponseSerializerContext.Default.DeleteDomainRecordResponse);
        }

        public static async Task<DeleteSubDomainRecordsResponse?> DeleteSubDomainRecordsAsync(string domain, string rr, string recordType, string value)
        {
            if (_option == null) return null;
            var query = new DeleteSubDomainRecordsQuery(domain, rr, recordType, _option.KeyId);
            return await GetAsync(query, DeleteSubDomainRecordsResponseSerializerContext.Default.DeleteSubDomainRecordsResponse);
        }

        public static async Task<UpdateDomainRecordRemarkResponse?> UpdateDomainRecordRemarkAsync(string recordId, string remark)
        {
            if (_option == null) return null;
            var query = new UpdateDomainRecordRemarkQuery(recordId, remark, _option.KeyId);
            return await GetAsync(query, UpdateDomainRecordRemarkResponseSerializerContext.Default.UpdateDomainRecordRemarkResponse);
        }


        private static async Task<Response?> GetAsync<Query, Response>(Query query, JsonTypeInfo<Response> jsonTypeInfo)
            where Query : AliyunQueryBase
            where Response : AliyunResponseBase
        {
            if (_client == null) return null;
            if (_option == null) return null;
            var queryStr = BuildQueryString(query.GetQuery());
            var signedStr = Signature("GET", _option.KeySecret, queryStr);
            var url = $"?Signature={signedStr}&{queryStr}";
            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize(content, jsonTypeInfo);
        }

        private static string BuildQueryString(SortedDictionary<string, string> paramDic)
        {
            var sb = new StringBuilder();
            foreach (var kv in paramDic)
            {
                sb.Append('&' + UrlEncode(kv.Key) + "=" + UrlEncode(kv.Value));
            }
            return sb.ToString()[1..];
        }

        private static string UrlEncode(string url)
        {
            return System.Net.WebUtility.UrlEncode(url).Replace("+", "%20").Replace("*", "%2A").Replace("%7E", "~");
        }

        private static string Signature(string method, string secKey, string str)
        {
            str = method.ToUpper() + '&' + UrlEncode("/") + '&' + UrlEncode(str);
            using var alg = new HMACSHA1(Encoding.UTF8.GetBytes(secKey + "&"));
            return UrlEncode(Convert.ToBase64String(alg.ComputeHash(Encoding.UTF8.GetBytes(str))));
        }
    }
}

