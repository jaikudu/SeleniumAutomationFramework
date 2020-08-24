using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.UI_Elements
{
    public class RegisterScenario
    {
        public RegisterScenario()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "userid")]
        public IWebElement UserIdField { get; set; }
        [FindsBy(How = How.Name, Using = "passid")]
        public IWebElement PasswordField { get; set; }
        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement UserNameField { get; set; }
        [FindsBy(How = How.Name, Using = "address")]
        public IWebElement AddressField { get; set; }
        [FindsBy(How = How.Name, Using = "country")]
        public IWebElement CountryField_DDL { get; set; }
        [FindsBy(How = How.Name, Using = "zip")]
        public IWebElement ZipField { get; set; }
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement EmailField { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(16) > input[type=radio]")]
        public IWebElement MaleField { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(17) > input[type=radio]")]
        public IWebElement FemaleField { get; set; }
        [FindsBy(How = How.Name, Using = "languageQuestion")]
        public IWebElement LanguageField { get; set; }
        [FindsBy(How = How.Name, Using = "desc")]
        public IWebElement AboutField { get; set; }
        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement RegisterButton { get; set; }
    }
}
