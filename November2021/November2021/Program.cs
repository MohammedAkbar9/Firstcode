using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace November2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver("F:/November2021/Firstcode/November2021");
            driver.Manage().Window.Maximize();
            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            // identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            // identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            // identify login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            // check if user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
            }

            //click on administration tab
            IWebElement administrationtab = driver.FindElement(By.XPath ("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationtab.Click();
          
            //select Time & Material from dropdown
            IWebElement tmdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmdropdown.Click();
           
            //click on Createnew button
            IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnewbutton.Click();


            //click on TypeCode dropdown and select Time

            IWebElement tmDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            tmDropdown.Click();


            IWebElement timeoption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeoption.Click();
            
            //enter code
            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.SendKeys ("November2021");

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
            IWebElement actualcode = driver.FindElement (By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if(actualcode.Text == "November2021")
            {
                Console.WriteLine("Time record created successfully.");
            }

            else
            {
                Console.WriteLine("Test failed.");
            }

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

            //Check the delete button
            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            DeleteButton.Click();
            Thread.Sleep(20000);
            
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Deleted item sucessfully");

            
        }
    }
}
    



