using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.UI_Elements;

namespace AutomationFramework
{
    public static class NavigateTo
    {
        public static void LoginFormThroughMenu()
        {
            Menu menu = new Menu();
            TestScenarioPage tsPage = new TestScenarioPage();

            menu.TestScenarios.Click();
            tsPage.LoginForm.Click();
        }
        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UserNameFieldPost ufPost = new UserNameFieldPost();

            menu.TestCases.Click();
            tcPage.UserNameFieldPost.Click();
            ufPost.LoginFormLink.Click();
        }
        public static void RegisterFormThroughMenu()
        {
            Menu menu = new Menu();
            TestScenarioPage tsPage = new TestScenarioPage();

            menu.TestScenarios.Click();
            tsPage.RegisterForm.Click();
        }
    }
}
