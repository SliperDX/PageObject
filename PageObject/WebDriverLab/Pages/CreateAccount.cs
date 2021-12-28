using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace WebDriverLab.Pages
{
    class CreateAccount
    {
        private const string PAGE_URL = "https://my.alpari.by/ru/accounts/open/demo";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"wizard\"]/div[1]/div/div[1]/div/div[1]/div/div/select")]
        protected readonly IWebElement typeAccount;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"wizard\"]/div[1]/div/div[1]/div/div[1]/div/div/select/option[2]")]
        protected readonly IWebElement Choise;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"wizard\"]/div[1]/div/div[1]/div/div[9]/div/div/input")]
        protected readonly IWebElement Password1;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"wizard\"]/div[1]/div/div[1]/div/div[10]/div/div/input")]
        protected readonly IWebElement Password2;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"wizard\"]/div[1]/div/div[1]/div/div[11]/div/input")]
        protected readonly IWebElement Price;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"wizard\"]/div[1]/div/div[1]/div/div[13]/div/button")]
        protected readonly IWebElement clickButton;

        [Obsolete]
        public CreateAccount(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            this.driver = driver;
            Thread.Sleep(1000);
            PageFactory.InitElements(driver, page: this);
        }

        public CreateAccount choiceTypeAccount()
        {
            Thread.Sleep(2000);
            typeAccount.Click();
            Choise.Click();
            return this;
        }

        public CreateAccount enterPassword()
        {
            Thread.Sleep(2000);
            Password1.SendKeys("Vladi111111");
            return this;
        }

        public CreateAccount repeatPassword()
        {
            Thread.Sleep(2000);
            Password2.SendKeys("Vladi111111");
            return this;
        }

        public CreateAccount enterPrice()
        {
            Thread.Sleep(2000);
            Price.Clear();
            Price.SendKeys("13000");
            Thread.Sleep(2000);
            return this;
        }
        //*[@id="my_accounts_table"]/tbody/tr[1]
        public CreateAccount submit()
        {
            Thread.Sleep(1000);
            clickButton.Click();
            return this;
        }
    }
}
