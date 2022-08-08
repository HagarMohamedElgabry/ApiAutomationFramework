using NUnit.Framework;
using RestSharp;
using System;


namespace APIAutomationFrameWork
{
    public class TestAPI
    {
        private IRestRequest _Request;
        private IRestClient _client;
        private IRestResponse _response;
        string url = "http://dummy.restapiexample.com/api/v1/employees";
        private Configuration _config;
        [Test]
        public void TestRequestIsSuccessfully()
        {

            _client = new RestClient();
            _Request = new RestRequest(url);
            _response = new RestResponse();
           _response = _client.Get(_Request);
           Assert.AreEqual((int)System.Net.HttpStatusCode.OK, (int)_response.StatusCode);
        }
    }
}
