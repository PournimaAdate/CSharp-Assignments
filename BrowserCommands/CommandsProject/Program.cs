using System;

namespace CommandsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           /* BrowserCmd b=new BrowserCmd();
            b.DemoQA();
            NavigationCmd n=new NavigationCmd();
            n.NavCmd();
            */

            HandleAlert ha=new HandleAlert();
            ha.AcceptAlert();
        }
    }
}
