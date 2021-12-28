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
    class Main
    {
        private const string PAGE_URL = "https://my.alpari.by/ru";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/nav/ul/li[2]")]
        protected readonly IWebElement myMoney;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/nav/ul/li[2]/ul/li[5]/a")]
        protected readonly IWebElement myConv;

        public Main(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            this.driver = driver;
            PageFactory.InitElements(driver, page: this);
        }

        public Main clickMyMoney()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", myMoney);
            Thread.Sleep(1000);
            return this;
        }
        //public Main clickMyConv()
        //{
        //    IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
        //    executor.ExecuteScript("arguments[0].click();", myConv);
        //    Thread.Sleep(2000);
        //    return this;
        //}

        public Main clickMyConv()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", myMoney);
            Thread.Sleep(2000);
            return this;
        }

        public Conv OpenPage()
        {
            Thread.Sleep(2000);
            return new Conv(driver);
        }
    }
}
