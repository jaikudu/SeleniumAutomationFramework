using AutomationFramework.UI_Elements;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.TestScenarios
{
    public class RegisterWithInvalidData
    {
        IAlert alert;
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.RegisterFormThroughMenu();
        }
        [Test]

        public void CheckIfAllElementsAreVisible()
        {
            RegisterScenario rPage = new RegisterScenario();

            Assert.Multiple(() => {
                Assert.That(rPage.UserIdField.Displayed, "User ID not displayed");
                Assert.That(rPage.UserNameField.Displayed, "User Name not displayed");
                Assert.That(rPage.PasswordField.Displayed, "Password not displayed");
            });

           

            
        }
        [Test]

        public void InvalidUserID_FourCharacters()
        {
            Actions.FillRegistrationForm(Config.RegistrationDetails.Invalid.UserID.FourCharacters, Config.RegistrationDetails.Valid.Password, Config.RegistrationDetails.Valid.UserName, Config.RegistrationDetails.Valid.Address, Config.RegistrationDetails.Valid.Country, Config.RegistrationDetails.Valid.Zip, Config.RegistrationDetails.Valid.Email);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessagesForRegister.UserIDLengthOutOfRange, alert.Text);

            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUP()
        {
            Driver.driver.Quit();
        }
    }
}
