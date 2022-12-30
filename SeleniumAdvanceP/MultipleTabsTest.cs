using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvanceP
{
    public class MultipleTabsTest
    {
        [Test]
        public void PhpMyAdminTabTest()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://db4free.net/";
            //driver.FindElement(By.XPath("//b[contains(text(),'phpMyAdmin »')]")).Click();

            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            ReadOnlyCollection<string> window = driver.WindowHandles;

            Console.WriteLine(window[0]);
            Console.WriteLine(window[1]);
            Console.WriteLine(driver.WindowHandles[1]);

        }

        [Test]
        public void Demo2PhpMyAdminTabTest()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://db4free.net/";
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("John");
            driver.FindElement(By.Id("input_password")).SendKeys("john123");
            driver.FindElement(By.Id("input_go")).Click();

            driver.Close();  //check what is happening 

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);

            driver.Quit();

        }

        [Test]
        public void Demo3PhpMyAdminTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.online.citibank.co.in/";
            driver.FindElement(By.XPath("//a[@class='fancybox-item fancybox-close']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Login')] ")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.XPath("//div[contains(text(),' Forgot User ID? ')]")).Click();
            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();
            driver.FindElement(By.Id("citiCard1")).SendKeys("4545");
            driver.FindElement(By.Id("citiCard2")).SendKeys("5656");
            driver.FindElement(By.Id("citiCard2")).SendKeys("8887");
            driver.FindElement(By.Id("citiCard2")).SendKeys("9998");
            driver.FindElement(By.Id("cvvnumber")).SendKeys("123");
            driver.FindElement(By.Id("bill-date-long")).Click();
            SelectElement month = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui-datepicker-month']")));
            month.SelectByText("Apr");
            SelectElement year = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")));
            year.SelectByText("2022");
            driver.FindElement(By.LinkText("14")).Click();
            driver.FindElement(By.XPath("//input[@class='ctaBlue minWidth']")).Click();
            //Thread.Sleep(1000);
            string textPrint = driver.FindElement(By.XPath("//li[contains(text(),'• Please accept Terms and Conditions ')]")).Text;
            Console.WriteLine(textPrint);
        }
    }

}
