using OpenQA.Selenium;

using EasyCrud.TestsUI.Helpers;
using EasyCrud.ViewModels;
using EasyCrud.TestsUI.Tests;
using System;

namespace EasyCrud.TestsUI.Tests
{
    public class KnowledgePage
    {
        private IWebDriver _driver;
        public KnowledgePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement Ionic
        {
            get
            {
                return _driver.FindElement(By.Id("ionic"));
            }
        }

        public IWebElement Ruby
        {
            get
            {
                return _driver.FindElement(By.Id("ruby"));
            }
        }

        public IWebElement Others
        {
            get
            {
                return _driver.FindElement(By.Id("others"));
            }
        }


        public IWebElement Photoshop
        {
            get
            {
                return _driver.FindElement(By.Id("photoshop"));
            }
        }

        public IWebElement Html
        {
            get
            {
                return _driver.FindElement(By.Id("html"));
            }
        }


        public IWebElement Cplusplus
        {
            get
            {
                return _driver.FindElement(By.Id("cpluplus"));
            }
        }


        public IWebElement Seo
        {
            get
            {
                return _driver.FindElement(By.Id("seo"));
            }
        }


        public IWebElement Illustrator
        {
            get
            {
                return _driver.FindElement(By.Id("illustrator"));
            }
        }

        public IWebElement Salesforce
        {
            get
            {
                return _driver.FindElement(By.Id("salesforce"));
            }

        }

        public IWebElement Java
        {
            get
            {
                return _driver.FindElement(By.Id("java"));
            }
        }


        public IWebElement Asp
        {
            get
            {
                return _driver.FindElement(By.Id("asp"));
            }
        }


        public IWebElement Jquery
        {
            get
            {
                return _driver.FindElement(By.Id("jquery"));
            }
        }


        public IWebElement Android
        {
            get
            {
                return _driver.FindElement(By.Id("android"));
            }
        }

        public IWebElement MySql
        {
            get
            {
                return _driver.FindElement(By.Id("mysql"));
            }
        }


        public IWebElement SqlServer
        {
            get
            {
                return _driver.FindElement(By.Id("sqlserver"));
            }
        }




        public IWebElement Angular
        {
            get
            {
                return _driver.FindElement(By.Id("angular"));
            }
        }

        public void FillKnowledge(CandidateViewModel candidate)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Ionic.EnterText(candidate.Ionic.ToString());
            Android.EnterText(candidate.Android.ToString());
            Angular.EnterText(candidate.Angular.ToString());
            Asp.EnterText(candidate.Asp.ToString());
            Others.EnterText(candidate.Others);
            Photoshop.EnterText(candidate.Photoshop.ToString());
            Illustrator.EnterText(candidate.Illustrator.ToString());
            Html.EnterText(candidate.Html.ToString());
            Jquery.EnterText(candidate.Jquery.ToString());
        }

    }
}
