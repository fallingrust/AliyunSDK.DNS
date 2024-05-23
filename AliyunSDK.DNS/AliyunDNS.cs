using AliyunDns.Core;
using AliyunDns.Core.Beans.Aliyun;
using AliyunSDK.DNS.Beans.Aliyun;
using AliyunSDK.DNS.Beans.Aliyun.Consts;
using AliyunSDK.DNS.Beans.Aliyun.Query;
using AliyunSDK.DNS.Beans.Aliyun.Response;
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

        /// <summary>
        /// 获取解析记录列表
        /// </summary>
        /// <param name="domain">域名名称</param>
        /// <returns></returns>
        public static async Task<DescribeDomainRecordsResponse?> DescribeDomainRecordsAsync(string domain)
        {
            if (_option == null) return null;
#if NET6_0_OR_GREATER
            return await GetAsync(new DescribeDomainRecordsQuery(domain, _option.KeyId), DescribeDomainRecordsResponseSerializerContext.Default.DescribeDomainRecordsResponse);
#else
            return await GetAsync<DescribeDomainRecordsQuery, DescribeDomainRecordsResponse>(new DescribeDomainRecordsQuery(domain, _option.KeyId));
#endif
        }
        /// <summary>
        /// 获取子域名解析记录列表
        /// </summary>
        /// <param name="subDomainName"></param>
        /// <returns></returns>
        public static async Task<DescribeSubDomainRecordsResponse?> DescribeSubDomainRecordsAsync(string subDomainName)
        {
            if (_option == null) return null;
#if NET6_0_OR_GREATER
            return await GetAsync(new DescribeSubDomainRecordsQuery(subDomainName, _option.KeyId), DescribeSubDomainRecordsResponseSerializerContext.Default.DescribeSubDomainRecordsResponse);
#else
            return await GetAsync<DescribeSubDomainRecordsQuery, DescribeSubDomainRecordsResponse>(new DescribeSubDomainRecordsQuery(subDomainName, _option.KeyId));
#endif
        }

        /// <summary>
        /// 修改域名解析记录
        /// </summary>
        /// <param name="record"></param>
        /// <param name="value">记录值</param>
        /// <returns></returns>
        public static async Task<UpdateDomainRecordResponse?> UpdateDomainRecordAsync(Record record, string value)
        {
            if (_option == null) return null;
            if (record == null) return null;
            if (string.IsNullOrEmpty(record.RecordId) || string.IsNullOrEmpty(record.RR) || string.IsNullOrEmpty(record.Type)) return null;
            var query = new UpdateDomainRecordQuery(record.RecordId, record.RR, record.Type, value, _option.KeyId);
#if NET6_0_OR_GREATER
            return await GetAsync(query, UpdateDomainRecordResponseSerializerContext.Default.UpdateDomainRecordResponse);
#else
            return await GetAsync<UpdateDomainRecordQuery, UpdateDomainRecordResponse>(query);
#endif
        }

        /// <summary>
        /// 添加解析记录
        /// </summary>
        /// <param name="domain">域名名称</param>
        /// <param name="rr">主机记录</param>
        /// <param name="type">解析记录类型</param>
        /// <param name="value">记录值</param>
        /// <returns></returns>
        public static async Task<AddDomainRecordResponse?> AddDomainRecordAsync(string domain, string rr, string type, string value)
        {
            if (_option == null) return null;
            var query = new AddDomainRecordQuery(domain, rr, type, value, _option.KeyId);
#if NET6_0_OR_GREATER
           return await GetAsync(query, AddDomainRecordResponseSerializerContext.Default.AddDomainRecordResponse);
#else
            return await GetAsync<AddDomainRecordQuery, AddDomainRecordResponse>(query);
#endif
        }

        /// <summary>
        /// 删除解析记录
        /// </summary>
        /// <param name="recordId">解析记录的 ID</param>
        /// <returns></returns>
        public static async Task<DeleteDomainRecordResponse?> DeleteDomainRecordAsync(string recordId)
        {
            if (_option == null) return null;
            var query = new DeleteDomainRecordQuery(recordId, _option.KeyId);
#if NET6_0_OR_GREATER
            return await GetAsync(query, DeleteDomainRecordResponseSerializerContext.Default.DeleteDomainRecordResponse);
#else
            return await GetAsync<DeleteDomainRecordQuery, DeleteDomainRecordResponse>(query);
#endif
        }

        /// <summary>
        /// 删除主机记录对应的解析记录
        /// </summary>
        /// <param name="domain">域名名称</param>
        /// <param name="rr">主机记录。如果要解析@.exmaple.com，主机记录要填写”@”，而不是空</param>
        /// <param name="type">解析记录类型。如果不填写，则返回子域名对应的全部解析记录类型</param>
        /// <returns></returns>
        public static async Task<DeleteSubDomainRecordsResponse?> DeleteSubDomainRecordsAsync(string domain, string rr, string type)
        {
            if (_option == null) return null;
            var query = new DeleteSubDomainRecordsQuery(domain, rr, type, _option.KeyId);
#if NET6_0_OR_GREATER
            return await GetAsync(query, DeleteSubDomainRecordsResponseSerializerContext.Default.DeleteSubDomainRecordsResponse);
#else
            return await GetAsync<DeleteSubDomainRecordsQuery, DeleteSubDomainRecordsResponse>(query);
#endif
        }

        /// <summary>
        /// 修改解析记录的备注
        /// </summary>
        /// <param name="recordId">解析记录 ID</param>
        /// <param name="remark">解析记录的备注信息</param>
        /// <returns></returns>
        public static async Task<UpdateDomainRecordRemarkResponse?> UpdateDomainRecordRemarkAsync(string recordId, string remark)
        {
            if (_option == null) return null;
            var query = new UpdateDomainRecordRemarkQuery(recordId, remark, _option.KeyId);
#if NET6_0_OR_GREATER
            return await GetAsync(query, UpdateDomainRecordRemarkResponseSerializerContext.Default.UpdateDomainRecordRemarkResponse);
#else
            return await GetAsync<UpdateDomainRecordRemarkQuery, UpdateDomainRecordRemarkResponse>(query);
#endif
        }

        /// <summary>
        /// 设置解析记录状态
        /// </summary>
        /// <param name="recordId">解析记录的 ID</param>
        /// <param name="status">解析记录状态。取值：Enable: 启用解析 Disable: 暂停解析</param>
        /// <returns></returns>
        public static async Task<SetDomainRecordStatusResponse?> SetDomainRecordStatusAsync(string recordId, string status)
        {
            if (_option == null) return null;
            var query = new SetDomainRecordStatusQuery(recordId, status, _option.KeyId);
#if NET6_0_OR_GREATER
            return await GetAsync(query, SetDomainRecordStatusResponseSerializerContext.Default.SetDomainRecordStatusResponse);
#else
            return await GetAsync<SetDomainRecordStatusQuery, SetDomainRecordStatusResponse>(query);
#endif
        }
     
        /// <summary>
        /// 获取解析记录的详细信息
        /// </summary>
        /// <param name="recordId">解析记录的 ID</param>
        /// <returns></returns>
        public static async Task<DescribeDomainRecordInfoResponse?> DescribeDomainRecordInfoAsync(string recordId)
        {
            if (_option == null) return null;
            var query = new DescribeDomainRecordInfoQuery(recordId, _option.KeyId);
#if NET6_0_OR_GREATER
            return await GetAsync(query, DescribeDomainRecordInfoResponseSerializerContext.Default.DescribeDomainRecordInfoResponse);
#else
            return await GetAsync<DescribeDomainRecordInfoQuery, DescribeDomainRecordInfoResponse>(query);
#endif
        }

        /// <summary>
        /// 生成txt记录
        /// </summary>
        /// <param name="domain">域名名称</param>
        /// <param name="type">txt 验证的功能。取值：ADD_SUB_DOMAIN、RETRIEVAL</param>
        /// <returns></returns>
        public static async Task<GetTxtRecordForVerifyResponse?> GetTxtRecordForVerifyAsync(string domain, string type)
        {
            if (_option == null) return null;
            var query = new GetTxtRecordForVerifyQuery(domain, type, _option.KeyId);
#if NET6_0_OR_GREATER
            return await GetAsync(query, GetTxtRecordForVerifyResponseSerializerContext.Default.GetTxtRecordForVerifyResponse);
#else
            return await GetAsync<GetTxtRecordForVerifyQuery, GetTxtRecordForVerifyResponse>(query);
#endif
        }
#if NET6_0_OR_GREATER
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
#else
        private static async Task<Response?> GetAsync<Query, Response>(Query query)
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
            return JsonSerializer.Deserialize<Response>(content);
        }
#endif
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

