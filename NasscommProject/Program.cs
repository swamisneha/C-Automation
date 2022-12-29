using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Nasscomm.Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://nasscom.in/";

            driver.FindElement(By.XPath("//a[contains(text(),'Login')]")).Click();
            driver.FindElement(By.XPath("//li[contains(text(),'register')] ")).Click();
            driver.FindElement(By.Id("edit-field-fname-reg-0-value")).SendKeys("Sneha");
            driver.FindElement(By.Id("edit-field-lname-0-value")).SendKeys("Swami");
            driver.FindElement(By.Id("edit-mail")).SendKeys("sneha@gmail.com");
            driver.FindElement(By.Id("edit-field-company-name-registration-0-value")).SendKeys("Google");

            SelectElement selectBusiness = new SelectElement(driver.FindElement(By.Id("edit-field-business-focus-reg")));
            selectBusiness.SelectByText("IT Consulting");

            driver.FindElement(By.Id("edit-submit--2")).Click();

        }
    }
}
