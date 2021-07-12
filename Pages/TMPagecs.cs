using divya21.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
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
            Wait.WaitForWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]","XPath",5);

            //identify time from the dropdown list
            IWebElement material = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            material.Click();
            Wait.WaitForWebElementToExist(driver, "//*[@id='TypeCode_listbox']/li[2]", "XPath", 5);


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



            //Identify save button and click and save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2500);
           


            //click go to last page

            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPage.Click();
            Wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 6);



            //check if record is pesent in the table as 
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            
            Assert.That(actualCode.Text == "May25", "actual code and expectted code did not match");
        }
        //Edit TM
        public void EditTM(IWebDriver driver)
        {
            //Click edit button


            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbutton.Click();
            Wait.WaitForWebElementToExist(driver, "Code", "ID", 5);

            //Edit code
            IWebElement ecode = driver.FindElement(By.Id("Code"));
            ecode.Clear();
            ecode.SendKeys("25");




            //edit description
            IWebElement edescription = driver.FindElement(By.Id("Description"));
            edescription.Clear();
            edescription.SendKeys("255");
            Wait.WaitForWebElementToExist(driver, "SaveButton", "ID", 5);

            //save changes

            IWebElement esave = driver.FindElement(By.Id("SaveButton"));
            esave.Click();
            
            Wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 5);

            //click go to last page

            IWebElement elast = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            elast.Click();
            Thread.Sleep(1000);

            //check if it is edited successfully

            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            if (actualDescription.Text == "255")
            {
                Assert.Pass("Time record edited successfully, test passed");
            }
            else
            {
                Assert.Fail("Test Failed");
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

            Wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]", "XPath", 20);


            IWebElement lastdescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement lastcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));





            // check if it is deleted successfully

            if (lastdescription.Text !="255" && lastcode.Text != "25")
            {
                Assert.Pass("Test pass");
            }
            else
            {
                Assert.Fail("Test fail");
            }
        }

        }
    }

