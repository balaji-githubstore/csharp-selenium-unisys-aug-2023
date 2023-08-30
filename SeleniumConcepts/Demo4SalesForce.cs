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
    /// <summary>
    /// Salesforce SignUp assignments 
    /// </summary>
    public class Demo4SalesForce
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("john");
            driver.FindElement(By.XPath("//input[contains(@id,'UserLas')]")).SendKeys("wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");

            SelectElement selectJobTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectJobTitle.SelectByValue("IT_Manager_AP");

            driver.FindElement(By.Name("CompanyName")).SendKeys("Unisys");


            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByText("United Kingdom");

            SelectElement selectEmp = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmp.SelectByText("101 - 200 employees");

            Console.WriteLine(driver.FindElement(By.Id("SubscriptionAgreement")).Selected);

            //if checkbox not selected then click
            if(driver.FindElement(By.Id("SubscriptionAgreement")).Selected==false)
            {
                driver.FindElement(By.XPath("//div[@class='checkbox-ui']")).Click();
            }

            Console.WriteLine(driver.FindElement(By.Id("SubscriptionAgreement")).Selected);

            driver.FindElement(By.Name("start my free trial")).Click();

            //span[contains(text(),'valid phone')]
            string actualError = driver.FindElement(By.XPath("//span[contains(@id,'UserPhone')]")).Text;
            Console.WriteLine(actualError);
        }
    }
}
