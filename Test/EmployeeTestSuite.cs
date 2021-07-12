using divya21.Pages;
using divya21.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace divya21.Test
{
    [TestFixture]
    [Parallelizable]
    class EmployeeTestSuite : CommonDriver
    {
        
        [Test]
        public void CreteemployeeTest()
        {
            //Object for Homepage
            HomePage homeobj = new HomePage();
            homeobj.GOTOEmployespage(driver);

            //Object for emPage
            Employeespage emobj = new Employeespage();
            emobj.createemployee(driver);

        }
        [Test]
        public void EditTMTest()
        {
            //Object for Homepage
            HomePage homeobj = new HomePage();
            homeobj.GOTOEmployespage(driver);
            //Object for eMPage

            Employeespage emobj = new Employeespage();
            emobj.Editemployee(driver);
        }
        [Test]
        public void DeleteTMTest()
        {
            //Object for Homepage
            HomePage homeobj = new HomePage();
            homeobj.GOTOEmployespage(driver);
            //Object for TMPage
            Employeespage emobj = new Employeespage();
            emobj.Deleteemployee(driver);
        }
    }
    
    }

