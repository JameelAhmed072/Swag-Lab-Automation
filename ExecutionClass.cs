using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;
using System.Threading;
using System.Configuration;



namespace STFinalProject
{
    [TestClass]
    public class ExecutionClass: BasePage
    {
        #region Setups and Cleanups
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext testContext)
        {
            string ResultFile = @"C:\Users\Jameel Ahmed\Desktop\AutomationBySirAmirImam\STFinalProject\STFinalProject\TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".html";
            CreateReport(ResultFile);
        }
        [AssemblyCleanup()]
        public static void AssemblyCleanup() 
        {
              extentReports.Flush();
        }
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }
        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }
        [TestInitialize()]
        public void TestInit()
        {
            BasePage.SeleniumInit("Chrome");
            Test = extentReports.CreateTest(TestContext.TestName);
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            //BasePage.driver.Close();
        }
        #endregion
        LoginPage loginPage = new LoginPage();
        SearchPage searchPage = new SearchPage();
        AddToCart addtoCart = new AddToCart();
        Hamburger hamburger = new Hamburger();  
        CartPage cartPage = new CartPage();  
        CheckOutPage checkOutPage = new CheckOutPage();
        
        [TestMethod]
        public void validUserNameAndPassword()
        {
            loginPage.Login("https://www.saucedemo.com", "standard_user", "secret_sauce");
            string actualText = driver.FindElement(By.ClassName("title")).Text;
            Assert.AreEqual("Products", actualText," Assert Failed: Login Not Performed");
            BasePage.driver.Close();
        }
        [TestMethod]
        public void inValidUserNameAndPassword()
        {
            loginPage.Login("https://www.saucedemo.com", "standardd_user", "secrett_sauce");
            string actualtext = driver.FindElement(By.CssSelector("#login_button_container > div > form > div.error-message-container.error")).Text;
            Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", actualtext);
            BasePage.driver.Close();
        }


        [TestMethod]
        public void dropDownSearch()
        {
            loginPage.Login("https://www.saucedemo.com", "standard_user", "secret_sauce");
            searchPage.Search();
            BasePage.driver.Close();
        }
        [TestMethod]
        public void cartBtn()
        {
            loginPage.Login("https://www.saucedemo.com", "standard_user", "secret_sauce");
            searchPage.Search();
            addtoCart.cartButton();
            BasePage.driver.Close();
        }
        [TestMethod]
        public void hamburgerBtn()
        {
            loginPage.Login("https://www.saucedemo.com", "standard_user", "secret_sauce");
            searchPage.Search();
            hamburger.ClickHamburgerMenu();
            BasePage.driver.Close();
        }
        [TestMethod]
        public void checkOutForm()
        {
            loginPage.Login("https://www.saucedemo.com", "standard_user", "secret_sauce");
            searchPage.Search();
            Thread.Sleep(1000);
            addtoCart.cartButton();
            Thread.Sleep(1000);
            cartPage.Cartpage();
            Thread.Sleep(1000);
            cartPage.CheckOutCart();
            checkOutPage.CheckoutForm("Jameel","Ahmed","2355");
            BasePage.driver.Close();
        }
       
        [TestMethod]
        public void CancelOrder()
        {
            loginPage.Login("https://www.saucedemo.com", "standard_user", "secret_sauce");
            Thread.Sleep(1000);
            addtoCart.BlackBag();
            addtoCart.AddBlackBagToCart();
            addtoCart.BackToProducts();
            addtoCart.RedShirt();
            addtoCart.AddRedShirtToCart();
            addtoCart.BackToProducts();
            Thread.Sleep(2000);
            cartPage.Cartpage();
            Thread.Sleep(2000);
            addtoCart.RemoveRedShirtToCart();
            Thread.Sleep(1000);
            cartPage.ContinueShopping();
            Thread.Sleep(1000);
            addtoCart.BlackShirt();
            Thread.Sleep(1000);
            addtoCart.AddBlackShirtToCart();
            Thread.Sleep(1000);
            addtoCart.BackToProducts();
            Thread.Sleep(1000);
            cartPage.Cartpage();
            Thread.Sleep(2000);
            cartPage.CheckOutCart();
            Thread.Sleep(2000);
            checkOutPage.CheckoutForm("Rameez", "Hassan", "2355");
            Thread.Sleep(1000);
            checkOutPage.CancelOrder();
            BasePage.driver.Close();
        }
        [TestMethod]
        public void OrderProducts()
        {
            loginPage.Login("https://www.saucedemo.com", "standard_user", "secret_sauce");
            Thread.Sleep(1000);
            addtoCart.BlackBag();
            addtoCart.AddBlackBagToCart();
            addtoCart.BackToProducts();
            addtoCart.RedShirt();
            addtoCart.AddRedShirtToCart();
            addtoCart.BackToProducts();
            addtoCart.RedShirt();
            addtoCart.RemoveRedShirtToCart();
            addtoCart.BackToProducts();
            Thread.Sleep(2000);
            cartPage.Cartpage();
            Thread.Sleep(2000);
            cartPage.CheckOutCart();
            Thread.Sleep(2000);
            checkOutPage.CheckoutForm("Jameel", "Ahmed", "2355");
            BasePage.driver.Close();
        }

    }
}
