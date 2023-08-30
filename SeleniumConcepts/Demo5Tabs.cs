using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo5Tabs
    {
        public static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();


            //Console.WriteLine(driver.WindowHandles[0]);
            //Console.WriteLine(driver.WindowHandles[1]);

            //switch to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin");
            driver.FindElement(By.Id("input_go")).Click();

            //get the message displayed "Access denied for user"
            string actualError= driver.FindElement(By.Id("pma_errors")).Text;
            Console.WriteLine(actualError);

            driver.Close(); //see which tab is closed

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);  //check the title 

            driver.Quit();
        }
    }
}
