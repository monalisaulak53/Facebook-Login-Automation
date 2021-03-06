using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Project
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.FindElement(By.Name("email")).SendKeys("test@gmail.com");
            driver.FindElement(By.Name("pass")).SendKeys("monalisatest");
            driver.FindElement(By.Name("login")).Click();
        }
    }
}