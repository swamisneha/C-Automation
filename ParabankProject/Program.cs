using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ParabankProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";

            driver.FindElement(By.Name("customer.firstName")).SendKeys("Sneha");
            driver.FindElement(By.Name("customer.lastName")).SendKeys("Swami");
            driver.FindElement(By.Id("customer.address.street")).SendKeys("Kharadi");
            driver.FindElement(By.Id("customer.address.city")).SendKeys("Pune");
            driver.FindElement(By.Id("customer.address.state")).SendKeys("Maharashtra");
            driver.FindElement(By.Id("customer.address.zipCode")).SendKeys("411014");
            driver.FindElement(By.Id("customer.phoneNumber")).SendKeys("8888360029");
            driver.FindElement(By.Id("customer.ssn")).SendKeys("123");
            driver.FindElement(By.Id("customer.username")).SendKeys("Sneha");
            driver.FindElement(By.Id("customer.password")).SendKeys("SnehaS@124");
            driver.FindElement(By.Id("repeatedPassword")).SendKeys("SnehaS@124");
            driver.FindElement(By.XPath("//input[@value='Register']")).Click();

        }
    }
}