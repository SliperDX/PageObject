using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace WebDriverLab.Pages
{
    class Conv
    {
        private const string PAGE_URL = "https://my.alpari.by/ru/conversion-rates";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/div/div/div[2]/div/div/div/form/div/div[1]/input")]
        protected readonly IWebElement data;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/div/div/div[2]/div/div/div/form/button")]
        protected readonly IWebElement button;

        [Obsolete]
        public Conv(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            this.driver = driver;
            Thread.Sleep(1000);
            PageFactory.InitElements(driver, page: this);
        }

        public Conv inputData()
        {
            Thread.Sleep(2000);
            data.Clear();
            data.SendKeys("2019-04-26");
            return this;
        }

        public Conv Submit()
        {
            Thread.Sleep(2000);
            button.Click();
            return this;
        }


        public string GetText()
        {
            string str = data.Text;
            return str;
        }


        //*[@id="my_accounts_table"]/tbody/tr[1]
    }
}
