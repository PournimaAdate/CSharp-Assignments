using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;


namespace CommandsProject
{
    class BrowserCmd
    {
        IWebDriver driver=new FirefoxDriver();
        FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\C# Training\BrowserCommands\CommandsProject\drivers");
        

        public void DemoQA()
        {
            
            driver.Navigate().GoToUrl("http://store.demoqa.com");
           
            string ps=driver.PageSource;
            int psLength=ps.Length;
            Console.WriteLine("\nPage Source: "+ps+"\nPage Source Length: "+psLength);
            Console.WriteLine("\n--------------------------------------");

             string title=driver.Title;
            int titleLength=title.Length;
            Console.WriteLine("\nTitle: "+title+"\nTitle Length: "+titleLength);
            Console.WriteLine("\n--------------------------------------");

            string url=driver.Url;
            int urlLength=url.Length;
            Console.WriteLine("\nURL: "+url+"\nURL Length: "+urlLength);
            Console.WriteLine("\n--------------------------------------");

            driver.Close();         


        }

        

    }
}