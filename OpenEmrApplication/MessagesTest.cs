using AutomationWrapper.Base;
using MetLife.OpenEmrApplication.Pages;
using MetLife.OpenEmrApplication.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetLife.OpenEmrApplication
{
    class MessagesTest : WebDriverWrapper
    {

        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "ValidSendMessageData")]
        public void ValidSendMessageTest(string usernamae,string password,string language,string pharmacyText,string statusText,string text,string expectedValue)
        {
            Console.WriteLine(usernamae+password+expectedValue);
            LoginPage login = new LoginPage(driver);
            login.LoginIntoDashboard(usernamae, password, language);

        }

    }
}
