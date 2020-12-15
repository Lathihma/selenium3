using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium3.login;
using selenium3.PageObjectModel;
using System;

namespace selenium3
{
    public class Tests : TestsBase
    {
        IWebDriver driver = new ChromeDriver();
        LoginPage login = new LoginPage();
        verifyLoginPage Verifyloginpage = new verifyLoginPage();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VerifyUserCanNavigateTohorseportal()
        {


            // invole a google chrome
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            var CurrentBrowserUrl = driver.Url;
            //Assert.AreEqual("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f",
            //  CurrentBrowserUrl);
            // driver.Close();
            //driver.Dispose();
            //enter the username
            Login(driver);
            //maximize the window
            driver.Manage().Window.Maximize();
            //Verifyloginpage( driver);
            // Assert.AreEqual
        }

        public static void Login(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("input[Name=UserName]")).SendKeys("hari");
            //enter the password
            driver.FindElement(By.CssSelector("input[id=Password]")).SendKeys("123123");
            //click submit button
            driver.FindElement(By.CssSelector("input[type=submit]")).Click();
        }

    }
}