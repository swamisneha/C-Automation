using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Maveric.SeleniumAdvanceP
{
    public class FrameTest
    {
        [Test]
        public void Demo1Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            _ = driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("Kevin123");

            driver.SwitchTo().DefaultContent();
        }

        public void Demo2Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
        }
    }
}
