using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace divya21.Utilities
{
    class Wait
    {
        //reusable function for wait
        public static void WaitforWebElementToExist(IWebDriver driver, string attributevalue,string attribute, int SecondsToWait)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, SecondsToWait));
            if (attribute == "XPath")
            {
               
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(attributevalue)));
            }
            if (attribute == "Id")
            {
                
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(attributevalue)));
            }
            if (attribute == "CssSelector")
            {
              
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(attributevalue)));
            }
        }

        internal static void WaitforWebElementToExist()
        {
            throw new NotImplementedException();
        }
    }
}
