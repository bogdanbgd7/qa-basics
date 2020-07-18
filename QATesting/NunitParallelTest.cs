using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace QATesting
{
    

    [TestFixture]
    [Parallelizable]
    public class NunitParallelTest : Base
    {
        [Test]
       public void SearchGoogle1()
       {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("q")).SendKeys("Selenium 1");
            //driver.FindElement(By.Name("btnK")).Click();

            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(6500);
       }

    [TestFixture]
    [Parallelizable]
        public class NunitParallelTest2 : Base
        {
            [Test]
            public void SearchGoogle2()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.google.com/");
                driver.Manage().Window.Maximize();

               

                driver.FindElement(By.Name("q")).SendKeys("Selenium 2");
                //driver.FindElement(By.Name("btnK")).Click();

                Actions builder = new Actions(driver);
                builder.SendKeys(Keys.Enter);

                System.Threading.Thread.Sleep(7500);
            }
        }
        

    }
}
