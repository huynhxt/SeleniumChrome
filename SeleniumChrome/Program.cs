using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumChrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            //Console.ReadKey();
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            IWebDriver driver = new ChromeDriver();

            string url = "https://student.tdt.edu.vn/taikhoan/dangnhap?ReturnUrl=https%3a%2f%2fstudent.tdt.edu.vn%3a443%2f";
            driver.Url = url;
            IWebElement webE = driver.FindElement(By.Id("MSSV"));
            webE.SendKeys("51603357");
            webE = driver.FindElement(By.Id("MK"));
            webE.SendKeys("Tubakemon1998");
            webE = driver.FindElement(By.CssSelector("input[type='submit']"));
            webE.Click();
            webE = driver.FindElement(By.Id("popup-thong-bao-off"));
            webE.Click();
            //square shrink brighten sq-tb
            //webE = driver.FindElement(By.ClassName("wrap-square"));
            //webE.FindElement(By.CssSelector("div[class='square shrink brighten sq-tb']"));
            //webE = driver.FindElement(By.CssSelector(".square.shrink.brighten.sq-tb"));
            //webE.Click();
            //webE = driver.FindElement(By.CssSelector("body"));
            //System.Threading.Thread.Sleep(5000);
            //webE.SendKeys(OpenQA.Selenium.Keys.Control + "t");
            //driver.SwitchTo().Window(driver.WindowHandles.Last());

            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            System.Threading.Thread.Sleep(5000);
            int i = 13456;
            driver.Navigate().GoToUrl("http://studentnews.tdtu.edu.vn/ThongBao/Detail/13616");

            int n = 0;
            while (n<1000)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                driver.Navigate().GoToUrl("http://studentnews.tdtu.edu.vn/ThongBao/Detail/" + i);
                //driver.Navigate().GoToUrl("http://studentnews.tdtu.edu.vn/ThongBao/Detail/"+i);
                i--;
                n++;
            }
            //10534 tin chua doc la ket qua truoc khi chay 100 tin
            Console.ReadKey();
            
        }
    }
}
