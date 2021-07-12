using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace divya21.Pages
{
    class Employeespage
    {
        // Test create employee
        public void createemployee(IWebDriver driver)
        {
            //click create new button
            IWebElement empcreate = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            empcreate.Click();
            Thread.Sleep(1000);
            // Identify name and input name
            IWebElement ename = driver.FindElement(By.Id("Name"));
            ename.SendKeys("Divya");


            // Identify username and input name
            IWebElement username = driver.FindElement(By.Id("Username"));
            username.SendKeys("Divs25");



            //Identify contact and Input contact
            IWebElement econtact = driver.FindElement(By.Id("ContactDisplay"));
            econtact.SendKeys("12345678");

            //Identify password and Input password
            IWebElement pwd = driver.FindElement(By.Id("Password"));
            pwd.SendKeys("P@tel2411");

            //Identify retype password and Input Password
            IWebElement rpwd = driver.FindElement(By.Id("RetypePassword"));
            rpwd.SendKeys("P@tel2411");

            // click save button and click and save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

           IWebElement BackToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            BackToList.Click();
            Thread.Sleep(2000);

            //click go to last page
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='usersGrid]/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(1000);
            //check if record is pesent in the table as 
            IWebElement actualusername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last]/td[2]"));

            Assert.That(actualusername.Text == "Divs25", "actual code and expectted code did not match");
        }
        // Test Edit employee
        public void Editemployee(IWebDriver driver)
        {

        }

        // Test delete employee
        public void Deleteemployee(IWebDriver driver)
        {

        }
    }
}
