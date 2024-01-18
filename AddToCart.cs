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
    public class AddToCart : BasePage
    {

        By clickCartButton = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");
        By a = By.Id("add-to-cart-sauce-labs-backpack");
        
        By blackBag = By.XPath("//*[@id=\"item_4_title_link\"]/div");
        // select the black bag
        By addBlacktoCart = By.Id("add-to-cart-sauce-labs-backpack");
        // add it to cart
        By backToProducts = By.Id("back-to-products");
        // back to products
        By redShirt = By.XPath("//*[@id=\"item_3_title_link\"]/div");
        // select red shirt
        By addRedShirt = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");
        By removeRedShirt = By.Id("remove-test.allthethings()-t-shirt-(red)"); // remove from cart
                                                                               //  again back to product

        By blackShirt = By.XPath("//*[@id=\"item_1_title_link\"]/div");
        // select the black bag
        By addBlackShirttoCart = By.Id("add-to-cart-sauce-labs-bolt-t-shirt");
        // add it to cart

        public void cartButton()
        {
            Step = Test.CreateNode("CartPage-CartButton");
            Thread.Sleep(1000);
            driver.FindElement(clickCartButton).Click();
            Thread.Sleep(2000);
            driver.FindElement(a).Click();
            Thread.Sleep(1000);
        }
        
        public void RedShirt()
        {
            Step = Test.CreateNode("CartPage-RedShirt");
            Thread.Sleep(2000);
            driver.FindElement(redShirt).Click();
        }
        public void AddRedShirtToCart()
        {
            Step = Test.CreateNode("CartPage-AddRedShirt");
            Thread.Sleep(2000);
            driver.FindElement(addRedShirt).Click();
        }
        public void RemoveRedShirtToCart()
        {
            Step = Test.CreateNode("CartPage-RemoveRedShirt");
            Thread.Sleep(2000);
            driver.FindElement(removeRedShirt).Click();
        }
        public void BlackBag()
        {
            Step = Test.CreateNode("CartPage-BlackBag");
            Step = Test.CreateNode("BlackBag");
            Thread.Sleep(1000);
            driver.FindElement(blackBag).Click();
        }
        public void AddBlackBagToCart()
        {
            Step = Test.CreateNode("CartPage-AddBlackBag");
            Thread.Sleep(2000);
            driver.FindElement(addBlacktoCart).Click();
        }
        public void BackToProducts()
        {
            Step = Test.CreateNode("CartPage-BackToProducts");
            Thread.Sleep(2000);
            driver.FindElement(backToProducts).Click();
        }
        public void BlackShirt()
        {
            Step = Test.CreateNode("CartPage-BlackShirt");
            Thread.Sleep(2000);
            driver.FindElement(blackShirt).Click();
        }
        public void AddBlackShirtToCart()
        {
            Step = Test.CreateNode("CartPage-AddBlackShirt");
            Thread.Sleep(2000);
            driver.FindElement(addBlackShirttoCart).Click();
        }
    }
}
