using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationFramework.UI_Elements;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }
        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();
            lsPost.UserNameField.Clear();
            lsPost.PasswordField.Clear();
            lsPost.RepeatPasswordField.Clear();
            lsPost.UserNameField.SendKeys(username);
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }
        public static void FillRegistrationForm(string userid, string password, string username, string address,string country, string zip, string email)
        {
            RegisterScenario rPost = new RegisterScenario();
            rPost.UserIdField.Clear();
            rPost.UserNameField.Clear();
            rPost.PasswordField.Clear();
            rPost.AddressField.Clear();
            rPost.EmailField.Clear();
            rPost.ZipField.Clear();
            new SelectElement(rPost.CountryField_DDL).SelectByText(country);
            rPost.UserNameField.SendKeys(username);
            rPost.PasswordField.SendKeys(password);
            rPost.UserIdField.SendKeys(userid);
            rPost.AddressField.SendKeys(address);
            rPost.EmailField.SendKeys(email);
            rPost.ZipField.SendKeys(zip);
            rPost.RegisterButton.Click();
        }
    }
}
