using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Medibuddy.Project
{
    public class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.medibuddy.in/";

            driver.FindElement(By.XPath("//a[contains(text(),'Login')]")).Click();
            driver.FindElement(By.ClassName("coperate")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'Login using Username & Password')]")).Click();
            driver.FindElement(By.Name("userName")).SendKeys("john");
            driver.FindElement(By.XPath("//button[contains(text(),'Proceed')]")).Click();
            driver.FindElement(By.Name("password")).SendKeys("john123");
            driver.FindElement(By.XPath("//span[contains(text(),'Show password')]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'Log in')]")).Click();

         

        }
    }
}