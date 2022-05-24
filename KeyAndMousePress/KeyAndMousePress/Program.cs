using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class program
    {
        static void Main(string[] args) 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://formy-project.herokuapp.com/keypress";
            IWebElement nameField = driver.FindElement(By.Id("name"));
            nameField.Click();
            nameField.SendKeys("General Kenobi");
            IWebElement button = driver.FindElement(By.Id("button"));
            button.Click();
            driver.Quit();

        }
    }
}
