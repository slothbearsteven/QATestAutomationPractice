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
            driver.Url = "http://formy-project.herokuapp.com/dropdown";

            IWebElement dropDownButton = driver.FindElement(By.Id("dropdownMenuButton"));
            dropDownButton.Click();

            IWebElement dropDownSelection = driver.FindElement(By.XPath("/html/body/div/div/div/a[6]"));
            dropDownSelection.Click();

       


            driver.Quit();

        }
    }
}
