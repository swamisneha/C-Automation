
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SeleniumAdvanceP
{ 
    public class UploadDemo
    {
        [Test]
        public void PdfToWordTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://db4free.net/";

            //Click on phpMyAdmin
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            ReadOnlyCollection<string> window = driver.WindowHandles;

            Console.WriteLine(window[0]);
            Console.WriteLine(window[1]);

        }

        [Test]
        public void PdfToWordTest2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.adobe.com/in/acrobat/online/convert-pdf.html";
            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys("C:\\Users\\snehaps\\Downloads\\SnehaPS.pdf");
        }
    }
}
