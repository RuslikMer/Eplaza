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
               
                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/products/digital_av/av_accessories/head_phone/RP-TCM50E/");
                driver.Manage().Window.Maximize();
                var catalog = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div/div[2]/div[2]/div[2]/div[2]/table/tbody/tr/td[3]/div/div/span/span/a[1]");
                catalog.Click();
                catalog = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/div[4]/a");
                catalog.Click();
                        
                // driver.SwitchTo().Frame("cboxWrapper");
                //string currentHandle = driver.CurrentWindowHandle;
                catalog = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/form/div[1]/div/div[1]/div[2]/div/a[2]");
                catalog.Click();
                //var popup = driver.FindElementByName("cboxContent");
                //popup.Click();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
                //PopupWindowFinder finder = new PopupWindowFinder(driver);
                //var a = driver.FindElementsById("cboxContent");
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                //string popupWindowHandle = finder.Click(catalog);
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
                //driver.SwitchTo().Window(popupWindowHandle);

                var user = driver.FindElementByName("USER_LOGIN");
                user.SendKeys("wensday@mail.ru");
                var password = driver.FindElementByName("USER_PASSWORD");
                password.SendKeys("rorshach1994");
                var login = driver.FindElementById("js_auth_button");
                login.Click();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
                var city = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/form/div[1]/div/div[1]/div[2]/div[2]/div/a/span");
                city.Click();
                Task.Delay(3000).Wait();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                city = driver.FindElementByXPath("/html/body/div[8]/div[1]/div[2]/div[2]/div[1]/div/div/div[2]/div[2]/div[1]/ul/li[1]/a");
                city.Click();
               
                //driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().First());
                Task.Delay(3000).Wait();
                city = driver.FindElementByName("ORDER_PROP_5");
                city.SendKeys("Тестовая");
                city = driver.FindElementByName("ORDER_PROP_4");
                city.SendKeys("121212");
                //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                Task.Delay(5000).Wait();
                city = driver.FindElementById("bonus-value");
                city.SendKeys("1");
                city = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/form/div[1]/div/div[5]/div[2]/div[2]/a");
                city.Click();
                //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                //driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                //city = driver.FindElementById("cboxClose"); 
                //city.Click();
                //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                //driver.SwitchTo().Window(driver.WindowHandles.ToList().First());
                city = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/form/div[1]/div/div[8]/a");
                city.Click();
                Console.ReadKey();

                                
            }
        }
    }
}
