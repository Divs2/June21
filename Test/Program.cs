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
    [Parallelizable]
    class Program : CommonDriver
    {
        

      
        [Test]
        public void CreteTMTest()
        {
            //Object for Homepage
            HomePage homeobj = new HomePage();
            homeobj.GOTOTMPages(driver);

            //Object for TMPage
            TMPagecs tmobj = new TMPagecs();
            tmobj.CreateTM(driver);

        }
        [Test]
        public void EditTMTest()
        {
            //Object for Homepage
            HomePage homeobj = new HomePage();
            homeobj.GOTOTMPages(driver);

            //Object for TMPage
            TMPagecs tmobj = new TMPagecs();
            tmobj.EditTM(driver);

        }
        [Test]
        public void DeleteTMTest()
        {
            //Object for Homepage
            HomePage homeobj = new HomePage();
            homeobj.GOTOTMPages(driver);

            //Object for TMPage
            TMPagecs tmobj = new TMPagecs();


            tmobj.DeleteTM(driver);

        }
       
    }
}
