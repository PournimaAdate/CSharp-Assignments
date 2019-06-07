using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
//using System.Web.UI.WebControls;
using System.Configuration;



namespace CommandsProject
{
    class HandleAlert
    {
         IWebDriver driver=new FirefoxDriver();
        FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\C# Training\BrowserCommands\CommandsProject\drivers");

        public void AcceptAlert()
        {
           /* driver.Navigate().GoToUrl("http://demo.guru99.com/test/delete_customer.php");
            driver.FindElement(By.Name("cusid")).SendKeys("abc");
            driver.FindElement(By.Name("submit")).Click();

            IAlert alert=driver.SwitchTo().Alert();
            //String alertMsg=driver.SwitchTo().Alert().GetText();
            String msg=alert.Text;
            Console.WriteLine("\n"+msg);
            alert.Accept();

             String msg2=alert.Text;
            Console.WriteLine("\n"+msg2);
            alert.Accept();*/


            driver.Navigate().GoToUrl("https://www.toolsqa.com/automation-practice-form/");
            driver.FindElement(By.XPath("//input[@name='firstname']")).SendKeys("abc");
            driver.FindElement(By.XPath("//*[contains(@name,'lastname')]")).SendKeys("xyz");
        }
    }
}
