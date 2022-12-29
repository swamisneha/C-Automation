using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Maveric.Salesforce
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");
            //driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");

            driver.FindElement(By.XPath("//input[contains(@id,'UserEma')]")).SendKeys("john@gmail.com");

            //driver.FindElement(By.Name("UserTitle")).SendKeys("IT Managere");

            SelectElement selectTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectTitle.SelectByText("IT Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric");
            driver.FindElement(By.Name("CompanyEmployees")).SendKeys("101-500 employees");
            //driver.FindElement(By.Name("UserPhone")).SendKeys("--");

            SelectElement selectEmployee = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployee.SelectByText("101-500 employees");

            //driver.FindElement(By.Name("CompanyCountry")).SendKeys("United Kingdom");
            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByText("United Kingdom");

            //driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.XPath("//div[@class='checkbox-ui']")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();

        }
    }
}