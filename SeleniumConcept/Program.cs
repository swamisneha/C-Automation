using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://github.com/login"; //Navigate the url

            string title = driver.Title; // Get current title
            Console.WriteLine(title);

            Console.WriteLine(driver.Url); //get current title
            //get the page source and print it
            Console.WriteLine(driver.PageSource);

            driver.FindElement(By.Id("login_field")).SendKeys("swamisneha124@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Sneha@124");
            driver.FindElement(By.Name("commit")).Click();




        }
    }
}