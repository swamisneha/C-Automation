using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvanceP
{
    public class Royal
    {
        [Test]
        public void RoyalCarybbean1()
        {
            
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Url = "https://www.royalcaribbean.com/";

                driver.FindElement(By.XPath("//div[@class='notification-banner__close']")).Click();
                driver.FindElement(By.Id("rciHeaderSignIn")).Click();

                driver.FindElement(By.XPath("//label[@class='footer__legal-name__label']")).Click();

                //driver.FindElement(By.XPath("//a[text()='Create an account']")).Click();
        }

    }
}
