using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace divya21.Pages
{
    class LoginPage
    {
        // function that allows to login in turn portal
        public void LoginActions(IWebDriver driver)
        {
          
            driver.Manage().Window.Maximize();


            // launch turnportal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");


            //identify username textbox  with valid user name
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //identify password textbox with valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //identify login action button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

        }
    }
}
