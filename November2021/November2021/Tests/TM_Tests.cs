using November2021.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace November2021
{
    class TM_Tests
    {
        static void Main(string[] args)
        {
            // open chrome browser

            IWebDriver driver = new ChromeDriver("F:/November2021/Firstcode/November2021");
            driver.Manage().Window.Maximize();

            // Login Page object initialization and identification

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LogInSteps(driver);

            // Home Page object initialization and identification
            Homepage homepageobj = new Homepage();
            homepageobj.GoToTMPage(driver);

            //TM Page object initialization and identification 

            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

            //Edit TM

            tmPageObj.EditTM(driver);

            //Delete TM

            tmPageObj.DeleteTM(driver);


        
           
           
        }
    }
}
    



