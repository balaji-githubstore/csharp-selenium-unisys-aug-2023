using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo7Alert
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            //click on Go
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            //wait for alert to be present

            string actualAlertText=driver.SwitchTo().Alert().Text;
            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();

            //goto https://nasscom.in/nasscom-membership
            //click on calculate fee
            //get the alert text and handle it
      
        }
    }
}
