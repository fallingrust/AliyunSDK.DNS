# AliyunSDK.DNS

<a href="https://www.nuget.org/packages/AliyunSDK.DNS">
  <img alt="Stars" src="https://buildstats.info/nuget/AliyunSDK.DNS">
</a>
<a href="https://github.com/fallingrust/AliyunSDK.DNS/graphs/contributors">
<img alt="Contributors" src="https://img.shields.io/github/contributors/fallingrust/AliyunSDK.DNS.svg?style=flat-square">
</a>
<a href="https://github.com/fallingrust/AliyunSDK.DNS/network/members">
<img alt="Forks" src="https://img.shields.io/github/forks/fallingrust/AliyunSDK.DNS.svg?style=flat-square">
</a>
<a href="https://img.shields.io/github/issues/fallingrust/AliyunSDK.DNS.svg">
<img alt="Issues" src="https://img.shields.io/github/issues/fallingrust/AliyunSDK.DNS.svg?style=flat-square">
</a>
<a href="https://github.com/fallingrust/AliyunSDK.DNS/blob/master/LICENSE.txt">
<img alt="MIT License" src="https://img.shields.io/github/license/fallingrust/AliyunSDK.DNS">
</a>
<a href="https://github.com/fallingrust/AliyunSDK.DNS/blob/master/LICENSE.txt">
<img alt="MIT License" src="https://img.shields.io/github/license/fallingrust/AliyunSDK.DNS">
</a>

### 关于

阿里云DNS SDK,支持AOT

### 使用

```cs
var option = new Option()
{
  EndPoint="https://alidns.cn-hangzhou.aliyuncs.com",
  KeyId = "ALIYUN_KEY_ID",
  KeySecret = "ALIYUN_KEY_SECRET"
};
AliyunDNS.Configure(option);
var response = await AliyunDNS.DescribeDomainRecordsAsync("domain");
```
