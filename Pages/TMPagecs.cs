using divya21.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace divya21.Pages
{
    class TMPagecs
    {
        //Create new TM
        public void CreateTM(IWebDriver driver)

        {
            //click create new button
            IWebElement createbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createbutton.Click();
            Wait.WaitforWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]","XPath",2);

            //identify time from the dropdown list
            IWebElement material = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            material.Click();
            Wait.WaitforWebElementToExist(driver, "//*[@id='TypeCode_listbox']/li[2]", "XPath", 5);


            IWebElement time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.Click();


            //identify code and input code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("May25");

            //identify description and input description
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("May25");


            //identify price per unit and input price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            IWebElement price = driver.FindElement(By.Id("Price"));
            price.SendKeys("25");



            //click save button

            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Wait.WaitforWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 10);


            //click go to last page

            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Wait.WaitforWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 10);



            //check if record is pesent in the table as 
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (actualCode.Text == "May25")
            {
                Console.WriteLine("Time record created successfully, test passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
        //Edit TM
        public void EditTM(IWebDriver driver)
        {
            //Click edit button


            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbutton.Click();
            Wait.WaitforWebElementToExist(driver, "Code", "ID", 5);

            //Edit code
            IWebElement ecode = driver.FindElement(By.Id("Code"));
            ecode.Clear();
            ecode.SendKeys("25");




            //edit description
            IWebElement edescription = driver.FindElement(By.Id("Description"));
            edescription.Clear();
            edescription.SendKeys("255");
            Wait.WaitforWebElementToExist(driver, "SaveButton", "ID", 5);

            //save changes

            IWebElement esave = driver.FindElement(By.Id("SaveButton"));
            esave.Click();

            Wait.WaitforWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 5);

            //click go to last page

            IWebElement elast = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            elast.Click();
            Wait.WaitforWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]", "XPath", 2);



            //check if it is edited successfully

            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            if (actualDescription.Text == "255")
            {
                Console.WriteLine("Time record edited successfully, test passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
        //Delete TM
        public void DeleteTM(IWebDriver driver)
        {
            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deletebutton.Click();
            
            //cick ok button
            driver.SwitchTo().Alert().Accept();
            //click go to last page

            IWebElement lastp = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastp.Click();

            Wait.WaitforWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]", "XPath", 2);


            IWebElement lastdescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement lastcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));





            // check if it is deleted successfully

            if (lastdescription.Text == "255" && lastcode.Text == "25")
            {
                Console.WriteLine("Test fail");
            }
            else
            {
                Console.WriteLine("Test pass");
            }
        }

        }
    }

