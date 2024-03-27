namespace AliyunDns.Core
{
    public class Option
    {     
        public string EndPoint { get; set; } = "https://alidns.cn-hangzhou.aliyuncs.com";
       
        public string KeyId { get; set; } = string.Empty;
        /// <summary>
        /// 阿里云RAM Access Key Secret
        /// </summary>
        public string KeySecret { get; set;} = string.Empty;
    }
}
