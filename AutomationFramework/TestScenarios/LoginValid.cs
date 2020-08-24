using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.TestScenarios
{
    public class LoginValid
    {
        IAlert alert;
        public LoginValid()
        {

        }
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {

            NavigateTo.LoginFormThroughMenu();

            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            
            //Implicit Wait
            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Explicit Wait       
            //WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromMilliseconds(10000));
            //wait.Until(ExpectedConditions.AlertState(false));

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUP()
        {
            Driver.driver.Quit();
        }
    }
}
