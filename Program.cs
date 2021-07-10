using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace divya21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // open crome browser
            IWebDriver driver = new ChromeDriver(@"C:\divya21\divya21");
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


            // check user login succesfully.
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if(helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Loggedin successfully, test passed");
            }
            else
            {
                Console.WriteLine("Log in failed, test failed");
            }

            // navigate to time and material page
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(1000);

            // click create new button
            IWebElement createbutton= driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createbutton.Click();
            Thread.Sleep(1000);

            //identify time from the dropdown list
            IWebElement material= driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            material.Click();
            Thread.Sleep(1000);

           IWebElement time =driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.Click();


            //identify code and input code
            IWebElement code =driver.FindElement(By.Id("Code"));
            code.SendKeys("May25");

            //identify description and input description
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("May25");


            //identify price per unit and input price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            IWebElement price= driver.FindElement(By.Id("Price"));
            price.SendKeys("25");



            //click save button

            IWebElement savebutton= driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(1500);


            //click go to last page

            IWebElement lastpage= driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(1000);


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

            //Click edit button


            IWebElement editbutton= driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbutton.Click();
            Thread.Sleep(1200);

            //Edit code
            IWebElement ecode= driver.FindElement(By.Id("Code"));
            ecode.Clear();
            ecode.SendKeys("25");




            //edit description
            IWebElement edescription = driver.FindElement(By.Id("Description"));
            edescription.Clear();
            edescription.SendKeys("255");
            Thread.Sleep(1000);
            
            //save changes

            IWebElement esave= driver.FindElement(By.Id("SaveButton"));
            esave.Click();

            Thread.Sleep(1500);

            //click go to last page

            IWebElement elast= driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            elast.Click();
            Thread.Sleep(1000);



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

            // click delete button
             IWebElement deletebutton= driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deletebutton.Click();
             Thread.Sleep(1200);
            //cick ok button
            driver.SwitchTo().Alert().Accept();
            //click go to last page

            IWebElement lastp = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
             lastp.Click();
            Thread.Sleep(1000);


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
