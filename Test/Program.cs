using divya21.Pages;
using divya21.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace divya21
{
    [TestFixture]
    class Program : CommonDriver
    {
        

        [SetUp]
        public void Loginsteps()
        {
            // open crome browser
            driver = new ChromeDriver(@"C:\divya21\divya21");

            //Object for loginpage
            LoginPage loginobj = new LoginPage();
            loginobj.LoginActions(driver);

            //Object for Homepage
            HomePage homeobj = new HomePage();
            homeobj.GOTOTMPages(driver);

        }
        [Test]
        public void CreteTMTest()
        {
            //Object for TMPage
            TMPagecs tmobj = new TMPagecs();
            tmobj.CreateTM(driver);

        }
        [Test]
        public void EditTMTest()
        {
            //Object for TMPage
            TMPagecs tmobj = new TMPagecs();
            tmobj.EditTM(driver);

        }
        [Test]
        public void DeleteTMTest()
        {
            //Object for TMPage
            TMPagecs tmobj = new TMPagecs();


            tmobj.DeleteTM(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}
