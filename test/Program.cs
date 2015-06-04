using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using LoginRegistration;
using System.Threading;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("\n\tENTER THE URL");
            string Url =Console.ReadLine();
            IWebDriver driver = new ChromeDriver(path);
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
           Common Obj = new Common();
            Obj.UserLogin("hcllego", "legohcl", driver);
            //Obj.UserRegistration(path, driver);
            Thread.Sleep(5000);
            driver.Quit();
            

        }
    }
}
