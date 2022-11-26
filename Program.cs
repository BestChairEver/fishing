using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace balls
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://spinningrat.online/");
            driver.FindElement(By.Id("start-instruction")).Click();
            Console.Clear();
            await Task.Delay(10000);
            IWebElement a = driver.FindElement(By.Id("view-counter"));
            string b = a.Text;
            Console.WriteLine(b);
        }
    }
}
