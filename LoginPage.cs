using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace STFinalProject
{
    [TestClass]
    public class LoginPage : BasePage
    {
        public void Login(string url, string user, string pass)
        {

            By usernameTxt = By.Id("user-name");
            By passwordTxt = By.Id("password");
            By loginBTN = By.Id("login-button");

            Step = Test.CreateNode("LoginPage");

            driver.Url = url;
            Thread.Sleep(1000);
            driver.FindElement(usernameTxt).SendKeys(user);
            Thread.Sleep(1000);
            driver.FindElement(passwordTxt).SendKeys(pass);
            Thread.Sleep(1000);
            driver.FindElement(loginBTN).Click();
            Thread.Sleep(1000);

        }
    }
}
