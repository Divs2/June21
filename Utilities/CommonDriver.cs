using divya21.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace divya21.Utilities
{
    class CommonDriver
    {
        public  IWebDriver driver;
        [OneTimeSetUp]
        public void Loginsteps()
        {
            // open crome browser
            driver = new ChromeDriver(@"C:\divya21\divya21");

            //Object for loginpage
            LoginPage loginobj = new LoginPage();
            loginobj.LoginActions(driver);

           
        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
