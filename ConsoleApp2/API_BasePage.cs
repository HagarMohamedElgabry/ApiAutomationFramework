using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace APIAutomationFrameWork
{
    public class API_BasePage
    {
        public void AssertResponseBody(string expectedFieldValue, string actualFieldValue)
        {

            Assert.AreEqual(expectedFieldValue, actualFieldValue);

        }


        public void AssertResponseCode(int expectedCode, int actualCode)
        {
            Assert.AreEqual(expectedCode, actualCode);
        }
    }
}
