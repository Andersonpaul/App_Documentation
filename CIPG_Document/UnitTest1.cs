using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CIPG_Documentation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            IWebElement element;
            driver = new ChromeDriver();
            driver.Url = "http://yahoomail.com/";
            element = driver.FindElement(By.Name("username"));
            string s = element.GetAttribute("maxlength");
            Console.WriteLine(s);
        }
    }
}
