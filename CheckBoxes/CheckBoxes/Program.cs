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
            driver.Url = "http://formy-project.herokuapp.com/checkbox";

            IWebElement checkBox1 = driver.FindElement(By.Id("checkbox-1"));
            checkBox1.Click();

            IWebElement checkBox2 = driver.FindElement(By.CssSelector("input[value='checkbox-2']"));
            checkBox2.Click();

            IWebElement checkBox3 = driver.FindElement(By.CssSelector("input[value='checkbox-3']"));
            checkBox3.Click();

            driver.Quit();

        }
    }
}
