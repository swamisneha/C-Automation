using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumAdvanceP
{
    public class Assignment
    {
        [Test]
        public void Redbus()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.redbus.in/";
            driver.FindElement(By.CssSelector("#sign-in-icon-down")).Click();
            driver.FindElement(By.CssSelector("#signInLink")).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='modalIframe']")));
            // driver.SwitchTo().Frame(driver.WindowHandles[1]);
            driver.FindElement(By.Id("mobileNoInp")).SendKeys("7859");
            string Msg = driver.FindElement(By.XPath("//span[contains(text(),'Please enter ')]")).Text;
            Console.WriteLine(Msg);
            // Console.WriteLine(driver.WindowHandles[1]);
        }

        [Test]
        public void AutomationWorld()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = " https://www.automationworld.com/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class='close-olytics-image-bottom-midpurple']")).Click();
            driver.FindElement(By.XPath("//span[@class='site-navbar__label']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//input[@id='id24_344']")).Click();
            driver.FindElement(By.XPath("//input[@name='demo59703']")).SendKeys("Sneha");
            driver.FindElement(By.XPath("//input[@id='id2']")).SendKeys("Swami");
            driver.FindElement(By.XPath("//input[@id='id10']")).SendKeys("Test Engineer");
            driver.FindElement(By.XPath("//input[@id='id195']")).SendKeys("https://maveric-systems.com/");
            driver.FindElement(By.XPath("//input[@id='id3']")).SendKeys("Maveric Systems");
            driver.FindElement(By.XPath("//input[@id='id11']")).SendKeys("5");
            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select[@name='demo59710']")));
            select.SelectByText("INDIA");
            driver.FindElement(By.XPath("//input[@id='id6']")).SendKeys("Chennai");
            driver.FindElement(By.XPath("//input[@id='id11']")).SendKeys("8888360029");
            driver.FindElement(By.XPath("//input[@id='id339_2327']")).Click();
            //string termAndConditions = driver.FindElement(By.XPath("//div[@id='disp59692']")).Text;
            //Console.WriteLine(termAndConditions);
            driver.FindElement(By.XPath("//input[@type=\"submit\"]")).Click();
            string errormessage = driver.FindElement(By.XPath("//li[contains(text(),'Email Address is required.')]")).Text;
            Console.WriteLine(errormessage);
        }
        [Test]
        public static void Openemr()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = " http://demo.openemr.io/b/openemr/";
            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");
            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select[@class='form-control']")));
            select.SelectByText("English (Indian)");
            driver.FindElement(By.Id("login-button")).Click();
            driver.FindElement(By.XPath("(//div[@aria-expanded='false'])[1]")).Click();
            driver.FindElement(By.XPath("(//div[@class='menuLabel px-1'])[6]")).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));
            driver.FindElement(By.Id("form_fname")).SendKeys("jack");
            driver.FindElement(By.Id("form_lname")).SendKeys("scic");
            driver.FindElement(By.Id("form_DOB")).SendKeys("01-01-2023");
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("form_sex")));
            select1.SelectByText("Male");
            SelectElement select2 = new SelectElement(driver.FindElement(By.Id("form_gender_identity")));
            select2.SelectByText("Identifies as Male");
            driver.FindElement(By.Id("create")).Click();
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='modalframe']")));
            driver.FindElement(By.XPath("//input[@value='Confirm Create New Patient']")).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(10000);
            string alerttext = driver.SwitchTo().Alert().Text;
            Console.WriteLine(alerttext);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(30000);
            // driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));
            driver.FindElement(By.XPath("//div[@data-dismiss='modal']")).Click();
            driver.SwitchTo().DefaultContent();
            string patientname = driver.FindElement(By.XPath("//span[@data-bind='text: pname()']")).Text;
            Console.WriteLine(patientname);
        }


        [Test]
        
        public void RoyalCarybbean()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.royalcaribbean.com/account/create";

           // driver.FindElement(By.XPath("//div[@class='notification-banner__close']")).Click();
            //driver.FindElement(By.Id("rciHeaderSignIn")).Click();

           // IWebElement ele = driver.FindElement(By.PartialLinkText("Create an account"));
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            //executor.ExecuteScript("arguments[0].click();", ele);

            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("Denis");
            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("Rich");

            driver.FindElement(By.XPath("//span[text()='Month']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'April')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Day')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),' 4 ')]")).Click();
            driver.FindElement(By.XPath("//input[@data-placeholder='Year']")).SendKeys("1990");
            driver.FindElement(By.XPath("//span[contains(text(),'Country/Region of residence')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'India')]")).Click();
           
        }

        [Test]
        public void PhpTravel()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.phptravels.net/home";

            driver.FindElement(By.XPath("(//i[@class='la la-angle-down'])[3]")).Click();
            driver.FindElement(By.LinkText("English")).Click();
            driver.FindElement(By.XPath("//span[text()='flights']")).Click();
            //driver.FindElement(By.XPath("//a[@class='active_flights waves-effect']")).Click();
            driver.FindElement(By.Id("autocomplete")).SendKeys("Los Angeles");
            driver.FindElement(By.Id("autocomplete2")).SendKeys("Dellas");
         
            driver.FindElement(By.Id("departure")).Clear();
            driver.FindElement(By.Id("departure")).SendKeys("2022-05-30");
            //driver.FindElement(By.XPath("//a[@class='dropdown-toggle dropdown-btn travellers waves-effect']")).Click();
            Thread.Sleep(30000);
            driver.FindElement(By.XPath("//a[@data-toggle='dropdown']")).Click();
            driver.FindElement(By.XPath("//i[@class='la la-plus']")).Click();
            driver.FindElement(By.Id("flights-search")).Click();
            Thread.Sleep(30000);
           string printdetails = driver.FindElement(By.XPath("//div[@class='theme-search-results-item-preview']")).Text;
           Console.WriteLine(printdetails);



        }


    }
}
