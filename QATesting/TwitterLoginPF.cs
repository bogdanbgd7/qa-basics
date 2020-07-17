using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace QATesting
{

    [TestClass]
    public class TwitterLoginPF
    {
        
        [TestMethod]
        public void VerifyTwitterLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.twitter.com/login");


            LoginPagePF loginPF = new LoginPagePF();
            PageFactory.InitElements(driver, loginPF);

            loginPF.Username.SendKeys("username");
            loginPF.Password.SendKeys("password");
            loginPF.ClickOnLoginButton();
            Thread.Sleep(2000);
        }
        
    }
}
