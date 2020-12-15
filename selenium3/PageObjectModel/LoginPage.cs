using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium3.login
{
    public class LoginPage

    {
       
        public void Login(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("input[Name=UserName]")).SendKeys("hari");
            //enter the password
            driver.FindElement(By.CssSelector("input[id=Password]")).SendKeys("123123");
            //click submit button
            driver.FindElement(By.CssSelector("input[type=submit]")).Click();
        }
    }
}
