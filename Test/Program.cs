using divya21.Pages;
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
           



            // open crome browser
            IWebDriver driver = new ChromeDriver(@"C:\divya21\divya21");

            //Object for loginpage
            LoginPage loginobj = new LoginPage();
            loginobj.LoginActions(driver);

            //Object for Homepage
            HomePage homeobj = new HomePage();
            homeobj.GOTOTMPages(driver);

            //Object for TMPage
            TMPagecs tmobj = new TMPagecs();
            tmobj.CreateTM(driver);
            tmobj.EditTM(driver);
            tmobj.DeleteTM(driver);


        }
    }
}
