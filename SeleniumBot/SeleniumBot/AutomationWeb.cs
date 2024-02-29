using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBot
{
    internal class AutomationWeb
    {
        public IWebDriver driver;

        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public string TestWeb()
        {

            // navigate to google
            driver.Navigate().GoToUrl("http://www.google.com");

            // reject cookies window button
            driver.FindElement(By.XPath("//*[@id=\"W0wltc\"]/div")).Click();

            //search for 
            driver.FindElement(By.XPath("//*[@id=\"APjFqb\"]")).SendKeys("what is RPA");

            // clik button search
            driver.FindElement(By.Name("btnK")).Click();

            // click first link
            driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div[1]/div/div/span/a")).Click();

            // get content
            var text = driver.FindElement(By.ClassName("sc-tfo41-7")).Text;

            return text;
        }
    }
}
