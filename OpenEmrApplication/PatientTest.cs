using AutomationWrapper.Base;
using MetLife.OpenEmrApplication.Pages;
using MetLife.OpenEmrApplication.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetLife.OpenEmrApplication
{
    class PatientTest : WebDriverWrapper
    {
        [Test, TestCaseSource(typeof(TestCaseSourceUtils), "AddPatientData")]
        public void AddPatientTest(string username,string password,string language,string firstname,string lastname,string dob,string gender,string expectedValue,string expectedValue2)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername("admin");
            login.EnterPassword("pass");
            login.SelectLanguageByText("English (Indian)");
            login.ClickOnLogin();

            //remaining steps needs to be completed
            DashboardPage dashboard = new DashboardPage(driver);
            dashboard.MouseOverOnPatientClients();

            driver.FindElement(By.XPath("//*[text()='Patients']")).Click();

            //remaining code complete here

        }

    
    }
}
