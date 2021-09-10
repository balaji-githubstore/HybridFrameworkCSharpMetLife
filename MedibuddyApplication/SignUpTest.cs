using AutomationWrapper.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedibuddyApplication
{
    class SignUpTest : WebDriverWrapper
    {
        [Test]
        public void ValidSignUpTest()
        {
            driver.FindElement(By.LinkText("Signup")).Click();

        }
    }
}
