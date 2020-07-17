using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QATesting
{
    [TestClass]
    public class TwitterLogin
    {

        [TestMethod]
        public void VerifyTwitterLogin()
        {

            try
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.twitter.com/login");


                //get LoginPage class
                LoginPage login = new LoginPage(driver);
                login.TypeUsername();
                login.TypePassword();
                login.ClickOnLoginButton();

                Thread.Sleep(2500);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            finally
            {
                
            }
            
          
        }

    }
}
