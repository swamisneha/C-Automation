using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

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
            Actions actions = new Actions(driver);
            try
            {
                actions.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }
            catch { }
           
            //driver.FindElement(By.XPath("//a[contains(text(),'Try Free')]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Try Free")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("John");
            driver.FindElement(By.Id("last-name")).SendKeys("wick");
            driver.FindElement(By.Id("login__email")).SendKeys("john@gmail.com");

            SelectElement selectSize = new SelectElement(driver.FindElement(By.XPath("//select[@class='select__select  ']")));
            selectSize.SelectByText("10-99");
            //try
            //{
            //    driver.FindElement(By.XPath("//button[contains(text()='Start My Trial')]")).Click();
            //}
            //catch { }
            //Thread.Sleep(5000);

            driver.FindElement(By.Id("contact-number")).SendKeys("1A");
            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();
            string err = driver.FindElement(By.XPath("//div[@class='inputField__requirements']")).Text;
            Console.WriteLine(err);


        }
    }
}