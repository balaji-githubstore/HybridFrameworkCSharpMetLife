using AutomationWrapper.Base;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MetLife.OrangeHRM
{
    public class LoginTest : WebDriverWrapper
    {
        [Test]
        public void ValidCredentialTest()
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin"); 
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();
        }
    }
}