using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    class program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://formy-project.herokuapp.com/autocomplete";

            IWebElement autocomplete = driver.FindElement(By.Id("autocomplete"));
            autocomplete.SendKeys("123 sesame");
            Thread.Sleep(1000);

            //due to the maps not loading correctly, targeted the dismissbutton instead
            IWebElement autocompleteResult = driver.FindElement(By.ClassName("dismissButton"));
            autocompleteResult.Click();

          


            driver.Quit();

        }
    }
}