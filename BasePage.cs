using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;
using System.Security.Policy;

namespace STFinalProject
{
    [TestClass]
    public class BasePage
    {
        #region Properties
        //public TestContext testContext;
        public static IWebDriver driver;

        public static ExtentReports extentReports;
        public static ExtentTest Test;
        public static ExtentTest Step;


        #endregion

        public void Write(By by, string data)
        {
            try
            {
                driver.FindElement(by).SendKeys(data);
                TakeScreenShot(Status.Pass, data + " : Data Entered Successfully");
            }
            catch(Exception ex)
            {
                TakeScreenShot(Status.Fail, "Failed to enter data : " + ex);
            }
            
        }
        public void Click(By by)
        {
            try
            {
                driver.FindElement(by).Click();
                TakeScreenShot(Status.Pass, " Clicked Successfully");
            }catch(Exception ex)
            {
                TakeScreenShot(Status.Fail, " Failed to Click:  " + ex);
            }
        }
        public void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }
        public void OpenUrl(string url)
        {
            driver.Url = url;
        }

        [TestMethod]
        public static void SeleniumInit(string browser)
        {
            if (browser == "Chrome")
            {
                var ChromeOptions = new ChromeOptions();
                ChromeOptions.AddArguments("--start-maximized");
                ChromeOptions.AddArguments("--incognito");
                IWebDriver chromeDriver = new ChromeDriver(ChromeOptions);
                driver = chromeDriver;
            }
            else if (browser == "FireFox")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArguments("");
                driver = new FirefoxDriver(options);
            }
        }
        public static void CreateReport(string path)
        {
            extentReports = new ExtentReports();
            var sparkReporter = new ExtentSparkReporter(path);
            extentReports.AttachReporter(sparkReporter);
        }

        public static void TakeScreenShot(Status status,string stepDetails)
        {
            string path = "C:\\Users\\Jameel Ahmed\\Desktop\\AutomationBySirAmirImam\\STFinalProject\\STFinalProject\\Images" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            File.WriteAllBytes(path, screenshot.AsByteArray);

            Step.Log(status, stepDetails,MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
        }
    }
}
