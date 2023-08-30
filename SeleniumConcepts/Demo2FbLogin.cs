using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo2FbLogin
    {
        public static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";

            //driver.FindElement(By.Id("email")).SendKeys("john123456@gmail.com");

            //By loc = By.Id("email");
            //IWebElement ele= driver.FindElement(loc);
            //ele.Click();

            IWebElement ele = driver.FindElement(By.Id("email"));
            ele.SendKeys("john123456@gmail.com");

            driver.FindElement(By.Id("pass")).SendKeys("welcome123");

            //click on login
            driver.FindElement(By.Name("login")).Click();
        }
    }
}
