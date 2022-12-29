using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Oracle.Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.oracle.com/in/database/";

            driver.FindElement(By.Id("acctBtnLabel")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Sign-In')] ")).Click();
            driver.FindElement(By.XPath("(//div[@class='cb41w1'])[1]"));
            String title = driver.Title;
            Console.WriteLine(title);
            String ur = driver.Url;
            Console.WriteLine(ur);
            Thread.Sleep(1000);
            IWebElement element = driver.FindElement(By.XPath("(//div[@class=\"cb41w1\"])[1]"));
            string text = element.Text;
            Console.WriteLine(text);
            Thread.Sleep(1000);
            driver.FindElement(By.Name("ssousername")).SendKeys("john");
            driver.FindElement(By.Name("password")).SendKeys("john123");
            driver.FindElement(By.Id("signin_button")).Click();
            Thread.Sleep(1000);
            String error = driver.FindElement(By.XPath("//span[@id=\"errormsg\"]")).Text;
            Console.WriteLine(error);

        }
    }
}
