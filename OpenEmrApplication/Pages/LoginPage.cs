using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetLife.OpenEmrApplication.Pages
{
    class LoginPage
    {
        private By usernameLocator = By.Id("authUser");
        private By passwordLocator = By.Id("clearPass");
        private By languageLocator = By.Name("languageChoice");
        private By loginLocator = By.XPath("//button[contains(text(),'Login')]");
        private By appDescLocator = By.XPath("//p[contains(text(),'most')]");
        private By errorLocator = By.XPath("//div[contains(text(),'Invalid')]");
        private By ackLicCertLocator = By.PartialLinkText("Certification");
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginIntoDashboard(string username,string password,string languageText)
        {
            EnterUsername(username);
            EnterPassword(password);
            SelectLanguageByText(languageText);
            ClickOnLogin();
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordLocator).SendKeys(password);
        }

        public void SelectLanguageByText(string languageText)
        {
            SelectElement selectLanguage = new SelectElement(driver.FindElement(languageLocator));
            selectLanguage.SelectByText(languageText);
        }

        public void ClickOnLogin()
        {
            driver.FindElement(loginLocator).Click();
        }

        public string GetApplicationDescription()
        {
            string appDesc = driver.FindElement(appDescLocator).Text;
            return appDesc;
        }

        public string GetAcknLicCertiLinkText()
        {
            return driver.FindElement(ackLicCertLocator).Text;
        }

        public string GetInvalidErrorMessage()
        {
            return driver.FindElement(errorLocator).Text.Trim();
        }

    }
}
