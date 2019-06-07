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
    class NavigationCmd
    {
        IWebDriver driver=new FirefoxDriver();
        FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\C# Training\BrowserCommands\CommandsProject\drivers");

        public void NavCmd()
        {
            driver.Navigate().GoToUrl("http://demoqa.com/");
            driver.FindElement(By.XPath("//a[contains(text(),'Sortable')]")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
           driver.Navigate().GoToUrl("http://demoqa.com/");
            driver.Navigate().Refresh();

             driver.Close();
        }
    }
}
        