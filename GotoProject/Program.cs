using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Goto.Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.goto.com/meeting/";

            driver.FindElement(By.Id("truste-consent-button")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Try Free')]")).Click();



        }
    }
}