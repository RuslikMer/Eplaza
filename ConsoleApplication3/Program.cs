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

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://vitamins.ru/");
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
                var butt = driver.FindElementByXPath("//*[@id=\"vishnya\"]/div[2]/a[1]");
                butt.Click();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
                var plus = driver.FindElementByXPath("/html/body/div[1]/div[1]/main/section/div/div[1]/div/div[1]/div[2]/div/div/i[2]");
                plus.Click();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
                butt = driver.FindElementByXPath("/html/body/div[1]/div[4]/div/div[3]/a");
                butt.Click();

                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
                //butt = driver.FindElement(By.XPath(("/html/body/div[2]/div/div/div/div[3]/div[1]/div[2]/div[2]/div/form/a")));
                
                butt = driver.FindElement(By.XPath(("/html/body/div[2]/div/div/div/div[3]/div[1]/div[2]/div[2]/div/form/a")));
                //driver.SwitchTo();
                //Console.WriteLine(butt.Text);
                butt.Click();
               
                Console.ReadKey();
            }
        }
    }
}
