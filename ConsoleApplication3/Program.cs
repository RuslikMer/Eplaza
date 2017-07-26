using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using OpenQA.Selenium.Firefox;
using System.Timers;
using Ionic.Zlib;
using OpenQA.Selenium.Interactions;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new ChromeDriver())
            {

                driver.Navigate().GoToUrl("https://club.panasonic.ru/");
                driver.Manage().Window.Maximize();
                var catalog = driver.FindElementByXPath("/html/body/div/div[3]/div[1]/div/div[2]/a/img");
                catalog.Click();
                catalog = driver.FindElementByName("DIRECT_CRM_NAME");
                catalog.SendKeys("dudles");
                catalog = driver.FindElementByName("DIRECT_CRM_LASTNAME");
                catalog.SendKeys("dudlik");
                var mail = driver.FindElementsByName("DIRECT_CRM_EMAIL");
                mail[1].SendKeys("dudles@mail.ru");
                mail = driver.FindElementsByName("DIRECT_CRM_PASSWORD");
                mail[1].SendKeys("123456q");
                catalog = driver.FindElementByName("DIRECT_CRM_CONFIRM_PASSWORD");
                catalog.SendKeys("123456q");
                catalog = driver.FindElementByXPath("/html/body/div/div[5]/aside/div/div[1]/div[2]/div[1]/form/select/option[1]");
                catalog.Click();
                catalog = driver.FindElementByName("DIRECT_CRM_BIRTHDAY");
                catalog.SendKeys("17121990");
                
                Console.ReadKey();


            }
        }
    }
}
