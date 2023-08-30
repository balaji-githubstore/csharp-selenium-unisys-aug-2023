using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.SeleniumConcepts2
{
    public class SeleniumAdvanceTest
    {
        [Test]
        public void UploadTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://smallpdf.com/pdf-to-word";
            //string file = "Balaji    Profile_2023_1.pdf";
            //driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Mine\" + file);
            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Mine\Balaji-Profile_2023_1.pdf");
        }

        [Test]
        public void Actions1Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://nasscom.in/";

            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();

            //click on Members Listing
            driver.FindElement(By.XPath("//a[text()='Members Listing']")).Click();
        }

        [Test]
        public void Actions2Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://nasscom.in/";

            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();

            //mousehover on Become a become
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a Member']"))).Perform();

            //click on Membership Benefits
            driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();

            //click to apply online element
            //driver.FindElement(By.PartialLinkText("CLICK TO APPLY")).Click();

            driver.FindElement(By.XPath("//a[text()='Click to Apply Online']")).Click();
        }

        [Test]
        public void Actions3Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://nasscom.in/";

            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Pause(TimeSpan.FromSeconds(1))
                .MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a Member']")))
                .Build().Perform();

            driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();
            driver.FindElement(By.XPath("//a[text()='Click to Apply Online']")).Click();
        }

        [Test]
        public void Action4Keyboard3Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.google.com/";

            Actions actions = new Actions(driver);
            actions.KeyDown(Keys.Shift).SendKeys("hello").KeyUp(Keys.Shift).Pause(TimeSpan.FromSeconds(1))
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Pause(TimeSpan.FromSeconds(1))
                 .SendKeys(Keys.Enter).Build().Perform();
        }
    }
}
