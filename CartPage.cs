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
    public class CartPage : BasePage
    {

        By clickCartIcon = By.ClassName("shopping_cart_link");
        By removeFromCart = By.XPath("/html/body/div/div/div/div[2]/div/div[1]/div[3]/div[2]/div[2]/button");
        By checkOutFromCart = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/button[2]");
        By continueShopping = By.Id("continue-shopping");



        public void Cartpage()
        {
            Step = Test.CreateNode("CartPage");
            driver.FindElement(clickCartIcon).Click();
            Thread.Sleep(1000);
        }
        public void RemoveCartItem()
        {
            Step = Test.CreateNode("CartPage-RemoveItemFromCart");
            driver.FindElement(removeFromCart).Click();
            Thread.Sleep(1000);
        }
        public void CheckOutCart()
        {
            Step = Test.CreateNode("CartPage-CheckOutFromCart");
            driver.FindElement(checkOutFromCart).Click();
            Thread.Sleep(1000);
        }
        public void ContinueShopping()
        {
            Step = Test.CreateNode("CartPage-ContinueShoppingBtn");
            driver.FindElement(continueShopping).Click();
            Thread.Sleep(1000);
        }



    }
}
