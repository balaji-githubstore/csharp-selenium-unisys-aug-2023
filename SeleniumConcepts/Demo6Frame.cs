using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo6Frame
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            //switch to frame using webelement 
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            //switch to frame using index
            //driver.SwitchTo().Frame(0);

            //switch to frame using name or id as string
            //driver.SwitchTo().Frame("login_page");


            //enter userid as john123
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("jack123");
            //click on continue
            driver.FindElement(By.LinkText("CONTINUE")).Click();


            //switch to main html
            driver.SwitchTo().DefaultContent();
        }
    }
}
