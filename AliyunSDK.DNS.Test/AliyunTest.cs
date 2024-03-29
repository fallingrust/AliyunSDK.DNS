namespace AliyunSDK.DNS.Test
{

    public class AliyunTest
    {
        private readonly string? _endPoint;
        private readonly string? _keyId;
        private readonly string? _secret;
        public AliyunTest()
        {
            _endPoint = Environment.GetEnvironmentVariable("EndPoint", EnvironmentVariableTarget.User);
            _keyId = Environment.GetEnvironmentVariable("KeyID", EnvironmentVariableTarget.User);
            _secret = Environment.GetEnvironmentVariable("Secret", EnvironmentVariableTarget.User);
            CheckConfig();
            AliyunDNS.Configure(new AliyunDns.Core.Option()
            {
                EndPoint = _endPoint,
                KeyId = _keyId,
                KeySecret = _secret
            });
        }


        [Theory]
        [InlineData("chenxuejian.cn")]
        public async Task DescribeDomainRecords_Test(string domain)
        {
            CheckConfig();
            var response = await AliyunDNS.DescribeDomainRecordsAsync(domain);
            Assert.NotNull(response);
        }
       
        [Theory]
        [InlineData("880970078750830592")]
        public async Task DescribeDomainRecordInfo_Test(string recordId)
        {
            CheckConfig();
            var response = await AliyunDNS.DescribeDomainRecordInfoAsync(recordId);
            Assert.NotNull(response);
        }

        [Theory]
        [InlineData("pi.chenxuejian.cn")]
        public async Task DescribeSubDomainRecords_Test(string domain)
        {
            CheckConfig();
            var response = await AliyunDNS.DescribeSubDomainRecordsAsync(domain);
            Assert.NotNull(response);
        }
        private void CheckConfig()
        {
            Assert.NotNull(_endPoint);
            Assert.NotNull(_keyId);
            Assert.NotNull(_secret);
        }
    }
}
