using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Selenium
{
    class program
    {
        static void Main(string[] args)
        {
         IWebDriver driver = new ChromeDriver();
         driver.Url = "http://formy-project.herokuapp.com/form";

         SubmitForm(driver);
         WaitForAlertBanner(driver);

         Assert.AreEqual("The form was successfully submitted!",GetAlertBannerText(driver));

         driver.Quit();

        }

        public static void SubmitForm(IWebDriver driver)
        {
            IWebElement firstName = driver.FindElement(By.Id("first-name"));
            firstName.SendKeys("General");

            IWebElement lastName = driver.FindElement(By.Id("last-name"));
            lastName.SendKeys("Kenobi");

            IWebElement jobTitle = driver.FindElement(By.Id("job-title"));
            jobTitle.SendKeys("Jedi Master");

            IWebElement radioButton2 = driver.FindElement(By.Id("radio-button-2"));
            radioButton2.Click();

            IWebElement checkbox1 = driver.FindElement(By.Id("checkbox-1"));
            checkbox1.Click();

            IWebElement dropdownButton = driver.FindElement(By.Id("select-menu"));
            dropdownButton.Click();

            IWebElement dropdownChoice = driver.FindElement(By.CssSelector("option[value='1']"));
            dropdownChoice.Click();

            IWebElement dateField = driver.FindElement(By.Id("datepicker"));
            dateField.SendKeys("05/31/2022");
            dateField.SendKeys(Keys.Return);

            IWebElement submitButton = driver.FindElement(By.CssSelector(".btn.btn-lg.btn-primary"));
            submitButton.Click();

        }

        public static void WaitForAlertBanner(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement alert = wait.Until(ExpectedConditions.ElementExists(By.ClassName("alert")));

        }

        public static string GetAlertBannerText(IWebDriver driver)
        {
            return driver.FindElement(By.ClassName("alert")).Text;
        }
    }
}
