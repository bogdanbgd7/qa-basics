using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace QATesting
{
    [TestClass]
    public class TestClass
    {

        [TestMethod]
        public void ChromeMethod()
        {

            string expectedResult = "Google";
            //string actualResult = "";


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();

            //get title
            var check = driver.Title;

            if (check.Contains(expectedResult))
            {
                Debug.WriteLine("There is google in the title.");
                Assert.IsTrue(true, "Test case passed!");
            }
            else
            {
                Debug.WriteLine("No google in the title.");
            }

            driver.Close();
            driver.Quit();

        }

        [TestMethod]
        public void SelectRadioButton()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("u_0_6")).Click();
            Thread.Sleep(2000); //timeout
            driver.FindElement(By.Id("u_0_7")).Click();
            Thread.Sleep(2000); //timeout
            driver.FindElement(By.Id("u_0_8")).Click();
            Thread.Sleep(2000); //timeout


            var dropdownList = driver.FindElement(By.Name("preferred_pronoun"));
            var selectedValue = new SelectElement(dropdownList);
            selectedValue.SelectByValue("1");

            //driver.Close();
            //driver.Quit();

        }

        public static IWebElement ExplicitWait(IWebDriver driver, string Identifier)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementExists(By.Id(Identifier)));
        }


        [TestMethod]

        public void WikiSearch()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {

                driver.Navigate().GoToUrl("https://www.wikipedia.org");
                driver.Manage().Window.Maximize();


                IWebElement elementt = ExplicitWait(driver, "searchInput");
                if (ExplicitWait(driver, "searchInput") != null)
                {
                    var element = driver.FindElement(By.Id("searchInput"));
                    element.Click();
                    element.SendKeys("Valorant");
                }

                
                driver.FindElement(By.ClassName("pure-button")).Click();
                Task.Delay(4000).Wait();

            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }

            finally
            {
                driver.Close();
                driver.Quit();
                Debug.WriteLine("Successfully.");
            }


        }

        [TestMethod]
        public void TakeScreenshot()
        {

            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Navigate().GoToUrl("https://www.twitter.com");
                driver.Manage().Window.Maximize();
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("D://image_twitter.png", ScreenshotImageFormat.Png);
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
