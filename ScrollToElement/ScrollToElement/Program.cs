using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    class program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://formy-project.herokuapp.com/scroll";
            IWebElement name = driver.FindElement(By.Id("name"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(name);
            name.SendKeys("General Kenobi");
            IWebElement date = driver.FindElement(By.Id("date"));
            date.SendKeys("03/02/2022");

            driver.Quit();

        }
    }
}
