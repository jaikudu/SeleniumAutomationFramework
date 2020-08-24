using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AutomationFramework.TestScenarios
{
    public class LoginInvalidUserName
    {
        IAlert alert;
        public LoginInvalidUserName()
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
            Actions.FillLoginForm(Config.Credentials.Invalid.UserName.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UserNameLengthOutOfRange, alert.Text);

            alert.Accept();
        }
        [Test]
        
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.UserName.ThirteenCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UserNameLengthOutOfRange, alert.Text);

            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUP()
        {
            Driver.driver.Quit();
        }
    }
}
