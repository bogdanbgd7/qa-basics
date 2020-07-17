using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QATesting
{
    public class LoginPagePF
    {
        //PF - PageFactory 
        //@FindBy
        //Cache Lookup
        

        [FindsBy(How =How.ClassName, Using = "r-1niwhzg")]
        [CacheLookup]
        public IWebElement Username { get; set; }

        [FindsBy(How=How.XPath, Using = ".//*[@id='react-root']/div/div/div[2]/main/div/div/form/div/div[2]/label/div/div[2]/div/input")]
        public IWebElement Password { get; set; }


        [FindsBy(How = How.ClassName, Using = ".r-sdzlij")]
        public IWebElement Login_Button { get; set; }

        public void ClickOnLoginButton()
        {
            Login_Button.Click();
        }


    }
}
