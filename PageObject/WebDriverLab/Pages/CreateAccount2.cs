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
    class CreateAccount2
    {
        private const string PAGE_URL = "https://my.alpari.by/ru/accounts";

        private IWebDriver driver;
      //  List<WebElement> elements = driver.findElements(By.name("elements_name"))

       [FindsBy(How = How.XPath, Using = "//*[@id=\"my_accounts_table\"]/tbody/tr[1]/td[3]")]
        protected readonly List<IWebElement> getPrice;

        [Obsolete]
        public CreateAccount2(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            this.driver = driver;
            Thread.Sleep(1000);
            PageFactory.InitElements(driver, page: this);
        }

        //public CreateAccount2 OpenHomePage()
        //{
        //    return new CreateAccount2(driver);
        //}

        private string id;
        public string GetPrice()
        {
            Thread.Sleep(2000);
            id = getPrice[0].Text; 
            Thread.Sleep(20000);
            return id;
        }
        //public CreateAccount2 OpenHomePage()
        //{
        //    driver.Navigate().GoToUrl(HOMEPAGE_URL);
        //    return this;
        //}
    }
}
