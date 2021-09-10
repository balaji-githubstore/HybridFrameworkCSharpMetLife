using AutomationWrapper.Base;
using MetLife.OpenEmrApplication.Pages;
using MetLife.OpenEmrApplication.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetLife.OpenEmrApplication
{
    class LoginTest : WebDriverWrapper
    {
        
        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "InvalidCredentialData")]
        public void InvalidCredentialTest(string username,string password,string languageText,string expectedValue)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.SelectLanguageByText(languageText);
            login.ClickOnLogin();

            string actualValue = login.GetInvalidErrorMessage();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "ValidCredentialData")]
        //[TestCase("admin", "pass", "English (Indian)","OpenEMR")]
        //[TestCase("physician", "physician", "English (Indian)", "OpenEMR")]

        public void ValidCredentialTest(string username,string password,string languageText,string expectedValue)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.SelectLanguageByText(languageText);
            login.ClickOnLogin();

            //wait condition required
            DashboardPage dashBoard = new DashboardPage(driver);
            String actualValue = dashBoard.GetTitle();

            Assert.AreEqual(expectedValue, actualValue); //fails on not matching
        }

        [Test]
        public void CheckLoginPageDisplayTest()
        {
            LoginPage login = new LoginPage(driver);

            string actualValue = login.GetApplicationDescription();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Acknowledgment,Licensing and Certification", login.GetAcknLicCertiLinkText());
                Assert.AreEqual("The most popular", actualValue);
            });


        }

    }
}
