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
    public class SearchPage : BasePage
    {

        By clickDropDown = By.ClassName("product_sort_container");
        By a = By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[2]");

        public void Search()
        {
            Step = Test.CreateNode("SearchPage");
            Thread.Sleep(1000);
            driver.FindElement(clickDropDown).Click();
            Thread.Sleep(1000);
            driver.FindElement(a).Click();
            Thread.Sleep(1000);

        }

    }
}
