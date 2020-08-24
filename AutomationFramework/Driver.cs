using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework
{
    public static class Driver
    {
        //public static IWebDriver driver = new ChromeDriver();
        public static IWebDriver driver { get; set; }
    }
}
