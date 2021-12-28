using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WebDriverLab.Pages;


namespace WebDriverLab
{
    class Tests
    {
        IWebDriver driver;


        [SetUp]
        public void SetupTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.alpari.by/login");
            Thread.Sleep(45000);
        }

        [Test]
        [Obsolete]
        public void AddUser()
        {
            Accounts page = new Accounts(driver);
            CreateAccount acountPage = page.OpenHomePage()
                .OpenPage();
            acountPage.choiceTypeAccount()
                .enterPassword()
                .repeatPassword()
                .enterPrice()
                .submit();
            Thread.Sleep(2000);
            //CreateAccount2 acountPage2 = new CreateAccount2(driver);
            Thread.Sleep(2000);
            //string getPrice = acountPage2.GetPrice();
            //Assert.IsTrue(data.Text != null);
            //Assert.AreEqual("USD 13000.00", getPrice);
            Thread.Sleep(20000);

        }

        [Test]
        public void Test2()
        {
            Main page = new Main(driver);
            Conv acountPage = page.clickMyMoney()
                .clickMyConv()
                .OpenPage();
            acountPage.inputData()
                .Submit();
            Thread.Sleep(2000);
            Assert.IsTrue(acountPage.GetText() != null);
        }

        [TearDown]
        public void TearDownTests()
        {
            if (driver != null)
                driver.Quit();
        }

    }
}
