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
            driver.Url = "http://formy-project.herokuapp.com/radiobutton";

            IWebElement radioButton1 = driver.FindElement(By.Id("radio-button-1"));
            radioButton1.Click();

            IWebElement radioButton2 = driver.FindElement(By.CssSelector("input[value='option2']"));
            radioButton2.Click();

            IWebElement radioButton3 = driver.FindElement(By.XPath("/html/body/div/div[3]/input"));
            radioButton3.Click();

            driver.Quit();

        }
    }
}
