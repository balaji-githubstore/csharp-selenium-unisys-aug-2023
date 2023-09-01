using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
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
        public void Demo1UploadTest()
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
        public void Demo2Actions1Test()
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
        public void Demo3Actions2Test()
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
        public void Demo4Actions3Test()
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
        public void Demo5Action4Keyboard3Test()
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


        [Test]
        public void Demo5OptionsDemo1Test()
        {
            ChromeOptions options = new ChromeOptions();
            options.AcceptInsecureCertificates = true;
            options.AddArgument("start-maximized");
            options.AddArgument("--disable-notifications");

            options.AddUserProfilePreference("download.default_directory", @"C:\");

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.irctc.co.in/nget/train-search";
        }

        [Test]
        public void Demo6JS()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.citibank.co.in/ssjsps/forgetuseridmidssi.jsp";

            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();

            driver.FindElement(By.CssSelector("#citiCard1")).SendKeys("7887");
            driver.FindElement(By.CssSelector("#citiCard2")).SendKeys("7887");

            driver.FindElement(By.CssSelector("input[name='CCVNO']")).SendKeys("888");

            //approach 1 - not working
            //driver.FindElement(By.Id("bill-date-long")).SendKeys("14/12/2000");

            //approach 2 - try to automate calendar 
            //driver.FindElement(By.Id("bill-date-long")).Click();

            //SelectElement selectYear = new SelectElement(driver.FindElement(By.CssSelector("[data-handler='selectYear']")));
            //selectYear.SelectByText("2000");

            //SelectElement selectMon = new SelectElement(driver.FindElement(By.CssSelector("[data-handler='selectMonth']")));
            //selectMon.SelectByText("Dec");

            //driver.FindElement(By.LinkText("14")).Click();

            //approach 3 - js
            //driver.ExecuteJavaScript("document.querySelector('#bill-date-long').value='14/12/2000'");

            //approach 4 - js and IWebElement
            IWebElement ele1 = driver.FindElement(By.XPath("//input[@id='bill-date-long']"));
            driver.ExecuteJavaScript("arguments[0].value='14/12/2000';", ele1);


            //read some data through js
            string title = driver.ExecuteJavaScript<string>("return document.title");
            Console.WriteLine(title);


            string duration = driver.ExecuteJavaScript<string>("return document.querySelectorAll(\"[class='video-stream html5-main-video']\")[0].duration");
            Console.WriteLine(duration);
        }

        [Test]
        public void Demo7FindElements()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.online.citibank.co.in/";

            //presence
            if (driver.FindElements(By.XPath("//a[@class='newclose']")).Count > 0)
            {
                //check for visiblity 
                if (driver.FindElement(By.XPath("//a[@class='newclose']")).Displayed)
                {
                    //click
                    string color = driver.FindElement(By.XPath("//a[@class='newclose']")).GetCssValue("color");
                    Console.WriteLine(color);
                    driver.FindElement(By.XPath("//a[@class='newclose']")).Click();
                }
            }

        }

        [Test]
        public void Demo8FindElements()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.google.com";

            var elements = driver.FindElements(By.XPath("//a"));

            Console.WriteLine(elements.Count);

            //0 to 24
            //elements[1].Click();

            //Console.WriteLine(elements[0].Text);
            //Console.WriteLine(elements[0].GetAttribute("href"));
            //Console.WriteLine(elements[0].GetCssValue("background-color"));
            //Console.WriteLine(elements[0].GetCssValue("color"));

            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine(elements[i].Text);
                Console.WriteLine(elements[i].GetAttribute("href"));
            }

            foreach (IWebElement element in elements)
            {
                Console.WriteLine(element.Text);
                Console.WriteLine(element.GetAttribute("href"));
            }
        }

        [Test]
        public void Demo9FluentWait()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";




            //click on Go
            // driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            //wait for alert to be present
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(10);
            //wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.IgnoreExceptionTypes(typeof(NoAlertPresentException));

            wait.Until(x => x.SwitchTo().Alert());

            string actualAlertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void Demo10FluentWait()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://facebook.com";

            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(10);
            //wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException),typeof(NoSuchElementException));
            wait.IgnoreExceptionTypes(typeof(Exception));

            //driver.FindElement(By.Id("email")).SendKeys("john123456@gmail.com");
            //driver.FindElement(By.Id("pass")).SendKeys("welcome123");

            wait.Until(x => x.FindElement(By.Id("email"))).SendKeys("jack123@gmail.com");

            string title = wait.Until(x => x.Title);
            Console.WriteLine(title);

            wait.Until(x => x.FindElement(By.Id("pass"))).SendKeys("welcome123");

        }
    }
}
