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
            driver.Url = "http://formy-project.herokuapp.com/datepicker";

            IWebElement dateField = driver.FindElement(By.Id("datepicker"));
            dateField.Click();
            dateField.SendKeys("08/29/2023");
            dateField.SendKeys(Keys.Return);


            driver.Quit();

        }
    }
}
