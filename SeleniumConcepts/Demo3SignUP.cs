using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcepts
{
    public class Demo3SignUP
    {
        public static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            driver.Url = "https://www.facebook.com/"; //wait for page load to complete

            //FindElement - takes only 0.5s to check presence of element 
            driver.FindElement(By.LinkText("Create new account")).Click();

            driver.FindElement(By.Name("firstname")).SendKeys("john");
            //enter lastname as wick
            driver.FindElement(By.Name("lastname")).SendKeys("wick");
            //enter password as welcome123
            driver.FindElement(By.Id("password_step_input")).SendKeys("welcome123");

            //20 Dec 2000
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("20");
            
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Dec");
            //selectMonth.SelectByValue("12");
            //selectMonth.SelectByIndex(11);

            //select year as 2000
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByText("2000");

            //click on custom radio button
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            //click on submit
            driver.FindElement(By.Name("websubmit")).Click();

        }
    }
}
