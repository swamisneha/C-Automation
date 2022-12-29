using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Maveric.DemoGuru
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://demo.guru99.com/test/newtours/register.php";

            driver.FindElement(By.Name("firstName")).SendKeys("john");
            driver.FindElement(By.Name("lastName")).SendKeys("killy");
            driver.FindElement(By.Name("phone")).SendKeys("8967546778");
            driver.FindElement(By.Id("userName")).SendKeys("John");
            driver.FindElement(By.Name("address1")).SendKeys("kharadi");
            driver.FindElement(By.Name("city")).SendKeys("Pune");
            driver.FindElement(By.Name("state")).SendKeys("Maharashtra");
            driver.FindElement(By.Name("postalCode")).SendKeys("411014");

            SelectElement selectCountry = new SelectElement( driver.FindElement(By.Name("country")));
            selectCountry.SelectByText("India");
            driver.FindElement(By.Name("email")).SendKeys("john12@gmail.com");
            driver.FindElement(By.Name("password")).SendKeys("john123");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("john123");
            driver.FindElement(By.Name("submit")).Click();
        }
    }
}