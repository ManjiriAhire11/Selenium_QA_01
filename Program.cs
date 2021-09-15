using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_QA_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

           
            //Launch chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //maximize browser
            driver.Manage().Window.Maximize();

            //Launch Url (google chrome)
            // driver.Url = "https://www.google.co.in";

            driver.Url = "https://m.facebook.com";
            driver.FindElement(By.Name("pass")).SendKeys("facebook");
                

    // IWebElement search_box = driver.FindElement(By.Name("q"));
           // search_box.SendKeys("Selenium");

           // driver.FindElement(By.Name("q")).SendKeys("Selenium");

           // driver.FindElement(By.LinkText("Gmail")).Click();

            //close browser
            //driver.Close();

        }
          
           
    }
}
