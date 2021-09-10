using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetLife.OpenEmrApplication.Pages
{
    class DashboardPage
    {
        private By messagesLocator = By.XPath("//div[text()='Messages']");
        private By flowBoardLocator = By.XPath("//div[text()='Flow Board']");
        private By patientClientLocator = By.XPath("//*[text()='Patient/Client']");

        private IWebDriver driver;

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetTitle()
        {
            return driver.Title.Trim();
        }

        public void ClickOnMessages()
        {
            driver.FindElement(messagesLocator).Click();
        }

        public void ClickOnFlowBoard()
        {
            driver.FindElement(flowBoardLocator).Click();
        }

        public void MouseOverOnPatientClients()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(patientClientLocator)).Perform();
        }
    }
}
