using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Maveric.SeleniumAdvance
{
    public class MultipleTabsTests
    {
        [Test]
        public static void PhpMyAdminTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://db4free.net/";
            driver.FindElement(By.XPath("//b[contains(text(),'phpMyAdmin »')]")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("John");

            driver.Close();

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);

            driver.Quit();
        }
    }
}
