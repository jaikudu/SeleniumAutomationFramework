using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.UI_Elements
{
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-58 > a")]
        public IWebElement TestScenarios { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-57 > a")]
        public IWebElement TestCases { get; set; }

    }
}
