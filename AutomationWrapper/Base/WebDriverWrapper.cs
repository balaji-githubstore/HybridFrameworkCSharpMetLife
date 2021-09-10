using AutomationWrapper.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AutomationWrapper.Base
{
    public class WebDriverWrapper
    {
        protected IWebDriver driver;

        [SetUp]
        public void Initialization()
        {
            string projectPath=Assembly.GetCallingAssembly().CodeBase;
            projectPath = projectPath.Substring(0, projectPath.IndexOf("bin"));
            projectPath = new Uri(projectPath).LocalPath;

            string json = projectPath + @"\TestData\data.json";
            string browser = JSONUtils.GetValueUsingKey(json, "browser");


            if (browser.ToLower().Equals("ff"))
            {
                driver = new FirefoxDriver(@"D:\B-Mine\Company\Company\MetLife\OpenEmrApplication\AutomationWrapper\Driver\");
            }
            else if (browser.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver(@"D:\B-Mine\Company\Company\MetLife\OpenEmrApplication\AutomationWrapper\Driver\");
            }
            else
            {
                driver = new ChromeDriver(@"D:\B-Mine\Company\Company\MetLife\OpenEmrApplication\AutomationWrapper\Driver\");
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = JSONUtils.GetValueUsingKey(json, "url");

        }

        [TearDown]
        public void EndBrowser()
        {
            driver.Quit();
        }
    }
}
