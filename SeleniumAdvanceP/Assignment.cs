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
        public static void Demo()
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




            // driver.FindElement(By.Id("authUser")).SendKeys("admin");
            //  driver.FindElement(By.Id("authUser")).SendKeys("admin");



        }


        [Test]
        
        public void RoyalCarybbean()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.royalcaribbean.com/";

            driver.FindElement(By.XPath("//div[@class='notification-banner__close']")).Click();
            driver.FindElement(By.Id("rciHeaderSignIn")).Click();

            IWebElement ele = driver.FindElement(By.LinkText("Create an account"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", ele);
            driver.FindElement(By.Id("mat-input-11")).SendKeys("Denis");
            driver.FindElement(By.Id("mat-input-12")).SendKeys("Rich");


            //driver.FindElement(By.XPath("//label[@class='footer__legal-name__label']")).Click();

            //driver.FindElement(By.XPath("//a[text()='Create an account']")).Click();

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
            driver.FindElement(By.XPath("//a[@class='active_flights waves-effect']")).Click();
            driver.FindElement(By.XPath("//input[@id='autocomplete']")).SendKeys("Los Angeles (LAX)");
            driver.FindElement(By.XPath("//input[@id='autocomplete2']")).SendKeys("Dallas (DAL)");
            driver.ExecuteJavaScript(("document.querySelector('#departure').value='2022-05-30';"));
            driver.FindElement(By.XPath("//a[@class='dropdown-toggle dropdown-btn travellers waves-effect']")).Click();
            driver.FindElement(By.ClassName(" dropdown-item adult_qty")).Click();
            driver.FindElement(By.ClassName("(//div[@class='qtyInc'])[1]")).Click();

        }


    }
}
