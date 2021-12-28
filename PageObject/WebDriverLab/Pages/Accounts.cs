using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebDriverLab.Pages
{
    class Accounts
    {
        private const string PAGE_URL = "https://my.alpari.by/ru/accounts/open";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"wizard\"]/div/div[3]/div/data-ng-include/div/div[2]/div/a")]
        protected readonly IWebElement createNewAccount;

        [Obsolete]
        public Accounts(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            this.driver = driver;
            PageFactory.InitElements(driver, page: this);
        }

        public Accounts OpenHomePage()
        {
            Thread.Sleep(2000);
            createNewAccount.Click();
            return this;
        }

        public CreateAccount OpenPage()
        {
            Thread.Sleep(2000);
            return new CreateAccount(driver);
        }

    }
}
