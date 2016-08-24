using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Web.Tests
{
    [Binding]
    public class LoginSuccessSteps
    {
        private ChromeDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:14058/Account/Login");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"輸入使用者名稱 ""(.*)""")]
        public void 假設輸入使用者名稱(string userName)
        {
            driver.FindElementById("UserName").SendKeys(userName);
        }
        
        [Given(@"輸入密碼 ""(.*)""")]
        public void 假設輸入密碼(string password)
        {
            driver.FindElementById("Password").SendKeys(password);
        }

        [When(@"登入時")]
        public void 當登入時()
        {
            driver.FindElementByClassName("btn").Click();
        }
        
        [Then(@"成功導到 Index 頁面")]
        public void 那麼成功導到Index頁面()
        {
            Assert.AreEqual("http://localhost:14058/Account", driver.Url);
        }
    }
}
