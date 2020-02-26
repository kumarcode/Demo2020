using DemoProject.Pages;
using DemoProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // define driver
            CommonDriver.driver = new ChromeDriver();

            // page object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(CommonDriver.driver);

            // page object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(CommonDriver.driver);

            // page object for TM page
            TMPage tmObj = new TMPage();

            // create new TM test case
            tmObj.AddTM(CommonDriver.driver);

            // edit TM test case
            tmObj.EditTM(CommonDriver.driver);

            // delete TM test case
            tmObj.DeleteTM(CommonDriver.driver);
        }
    }
}
