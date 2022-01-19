using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace November2021.Pages
{
    class Homepage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            //click on administration tab
            IWebElement administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationtab.Click();

            //select Time & Material from dropdown
            IWebElement tmdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmdropdown.Click();
        }


    }
}
