using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QATesting
{
    //POM
    public class LoginPage
    {
        IWebDriver driver;
        By Username = By.ClassName("r-1niwhzg");
        By Password = By.XPath(".//*[@id='react-root']/div/div/div[2]/main/div/div/form/div/div[2]/label/div/div[2]/div/input");
        By login_button = By.ClassName("r-sdzlij");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUsername()
        {
            driver.FindElement(Username).SendKeys("username");
        }

        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("password");
        }

        public void ClickOnLoginButton()
        {
            driver.FindElement(login_button).Click();
        }


    }
}
