using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Threading;

namespace QATesting
{
    [TestClass]
    public class HandlingAlerts
    {

        IWebDriver driver;

        [TestMethod]
        public void SimpleAlert()

        {
            try
            {
                driver = new ChromeDriver(); 
                driver.Navigate().GoToUrl("https://www.toolsqa.com/handling-alerts-using-selenium-webdriver/");
                driver.Manage().Window.Maximize();

                IWebElement SimpleAlertButton = driver.FindElement(By.XPath("//button[.='Simple Alert']"));
                //implicit wait
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                SimpleAlertButton.Click();
                IAlert alert = driver.SwitchTo().Alert();
                Debug.WriteLine("\n\n\n\n\n\n" +alert.Text + "\n\n\n\n");
                alert.Accept();
                driver.SwitchTo().DefaultContent();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Quit();
            }
        }

        [TestMethod]
        public void ConfirmAlert()

        {
            try
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.toolsqa.com/handling-alerts-using-selenium-webdriver/");
                driver.Manage().Window.Maximize();

                IWebElement ConfirmAlertButton = driver.FindElement(By.XPath("//button[.='Confirm Pop up']"));
                ConfirmAlertButton.Click();
                IAlert alert = driver.SwitchTo().Alert();
                Debug.WriteLine("\n\n\n\n\n\n" + alert.Text + "\n\n\n\n");
                //alert.Accept();
                alert.Dismiss();
                driver.SwitchTo().DefaultContent();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
