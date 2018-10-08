using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace EasyCrud.TestsUI
{
    public abstract class SeleniumBase : IDisposable
    {
        public IWebDriver driver;
        protected string url = "http://localhost:4200/form";

        public SeleniumBase()
        {
            try
            {
                driver = new ChromeDriver("C://TEMP");
                driver.Manage().Window.Maximize();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao rodar o chrome..." + ex.Message);
               
            }
        }

        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao finalizar o chrome..." + ex.Message);
            }
        }
    }
}
