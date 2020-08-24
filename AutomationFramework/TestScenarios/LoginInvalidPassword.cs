using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AutomationFramework.TestScenarios
{
    public class LoginInvalidPassword
    {
        IAlert alert;
        public LoginInvalidPassword()
        {

        }
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughMenu();
        }
        [Test]
       
        public void LessThan5Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters);
            
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.IncorrectPassword, alert.Text);

            alert.Accept();
        }
        [Test]
      
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.IncorrectPassword, alert.Text);

            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUP()
        {
            Driver.driver.Quit();
        }
    }
}
