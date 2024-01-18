using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFinalProject
{
    [TestClass]
    public class Hamburger : BasePage
    {
        By clickHamburg = By.Id("react-burger-menu-btn");
        public void ClickHamburgerMenu()
        {
            Step = Test.CreateNode("Hamburger-Menu");
            Step = Test.CreateNode("ClickHamburgerMenu");
            driver.FindElement(clickHamburg).Click();

        }

    }
}
