using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAuto
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://opensource-demo.orangehrmlive.com/";

            driver.FindElement(By.Name("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Name("txtPassword")).SendKeys("admin123 ");
            driver.FindElement(By.Id("btnLogin")).Click();

        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }

    }
}