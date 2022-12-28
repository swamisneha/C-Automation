using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Facebook
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/signup";


        }
    }
}