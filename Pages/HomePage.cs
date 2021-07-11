using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace divya21.Pages
{
    class HomePage
    {
        //function navigate to tm page
        public void GOTOTMPages(IWebDriver driver)
        {
            // navigate to time and material page
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(1000);
        }
    }
}
