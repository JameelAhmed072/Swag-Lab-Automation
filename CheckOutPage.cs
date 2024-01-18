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
    public class CheckOutPage : BasePage
    {
        By fNameText = By.Id("first-name");
        By lNameText = By.Id("last-name");
        By zipCodeText = By.Id("postal-code");
        By btn = By.Id("continue");
        By finishBtn = By.Id("finish");
        By home = By.Id("back-to-products");
        By cancelOrder = By.Id("cancel");

        public void CheckoutForm(string fName, string lName, string zipCode)
        {
            Step = Test.CreateNode("CheckOutPage-CheckOutForm");
            Thread.Sleep(1000);
            driver.FindElement(fNameText).SendKeys(fName);
            Thread.Sleep(1000);
            driver.FindElement(lNameText).SendKeys(lName);
            Thread.Sleep(1000);
            driver.FindElement(zipCodeText).SendKeys(zipCode);
            Thread.Sleep(1000); 
            driver.FindElement(btn).Click();
        }
        public void finishOrder()
        {
            Step = Test.CreateNode("CheckOutPage-FinishOrder");
            Step = Test.CreateNode("CheckOutPage");
            Thread.Sleep(1000);
            driver.FindElement(finishBtn).Click();
        }
        public void backToHomeBtn()
        {
            Step = Test.CreateNode("CheckOutPage-BackToHomeBtn");
            Step = Test.CreateNode("CheckOutPage");
            Thread.Sleep(1000);
            driver.FindElement(home).Click();
            Thread.Sleep(1000);
        }
        public void CancelOrder()
        {
            Step = Test.CreateNode("CheckOutPage-CancelOrder");
            Step = Test.CreateNode("CheckOutPage");
            Thread.Sleep(1000);
            driver.FindElement(cancelOrder).Click();
        }

    }
}
