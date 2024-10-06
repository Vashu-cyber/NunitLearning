using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject1.utilities;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1
{
    public class SeleniumFirst : Base
    {
        

        

        [Test]
        public void TestBrowserLocator()
        {
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Id("username")).Clear();
           

        }

        
    }
}
