using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace November2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //click on CreateNew Button
            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewButton.Click();

            //click on TypeCode dropdown and select Time

            IWebElement tmDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            tmDropdown.Click();


            IWebElement timeoption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeoption.Click();

            //enter code
            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.SendKeys("November2021");

            //enter description
            IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
            descriptiontextbox.SendKeys("November2021");

            //enter price
            IWebElement pricetag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            pricetag.Click();

            IWebElement pricetextbox = driver.FindElement(By.Id("Price"));
            pricetextbox.SendKeys("10");

            //click on save button
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(5000);

            //click on go to last page button
            IWebElement gotolastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpagebutton.Click();

            //check if time record is present and has expected value
            IWebElement actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualcode.Text == "November2021")
            {
                Console.WriteLine("Time record created successfully.");
            }

            else
            {
                Console.WriteLine("Test failed.");
            }

        }

        public void EditTM(IWebDriver driver)
            {
                IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                EditButton.Click();
                Thread.Sleep(2000);

                //Edit the description in Edit page
                IWebElement Descriptionedittextbox = driver.FindElement(By.Id("Description"));
                Descriptionedittextbox.Clear();
                Descriptionedittextbox.SendKeys("2020");

                //Click on save button in edit page
                IWebElement EditSaveButton = driver.FindElement(By.Id("SaveButton"));
                EditSaveButton.Click();
                Thread.Sleep(20000);

            }
            public void DeleteTM(IWebDriver driver)
            {
                //Check the delete button
                IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                DeleteButton.Click();
                Thread.Sleep(2000);
                driver.SwitchTo().Alert().Accept();
                Console.WriteLine("Deleted item sucessfully");
            }
        }

    }

