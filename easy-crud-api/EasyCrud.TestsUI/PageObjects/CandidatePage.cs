using OpenQA.Selenium;

using EasyCrud.TestsUI.Helpers;
using EasyCrud.ViewModels;
using EasyCrud.TestsUI.Tests;

namespace EasyCrud.TestsUI.PageObject
{
    public class CandidatePage
    {
        private IWebDriver _driver;
        private KnowledgePage _knowledgePage;
        public CandidatePage(IWebDriver driver)
        {
            _driver = driver;
            _knowledgePage = new KnowledgePage(_driver);
        }

        private IWebElement Email {
            get
            {
                return _driver.FindElement(By.Id("email"));
            }
        }

        private IWebElement Name
        {
            get
            {
                return _driver.FindElement(By.Id("name"));
            }
        }
        private IWebElement Cellphone
        {
            get
            {
                return _driver.FindElement(By.Id("cellphone"));
            }
        }

        private IWebElement SkypeAddress
        {
            get
            {
                return _driver.FindElement(By.Id("skypeAddress"));
            }
        }


        private IWebElement City
        {
            get
            {
                return _driver.FindElement(By.Id("city"));
            }
        }


        private IWebElement State
        {
            get
            {
                return _driver.FindElement(By.Id("state"));
            }
        }


        private IWebElement Portfolio
        {
            get
            {
                return _driver.FindElement(By.Id("portfolio"));
            }
        }


        private IWebElement FourHours
        {
            get
            {
                return _driver.FindElement(By.Id("fourHours"));
            }
        }

        private IWebElement FourSixHours
        {
            get
            {
                return _driver.FindElement(By.Id("fourSixHours"));
            }
        }


        private IWebElement SixEightHours
        {
            get
            {
                return _driver.FindElement(By.Id("sixEightHours"));
            }
        }

        private IWebElement HoursOnWeekends
        {
            get
            {
                return _driver.FindElement(By.Id("hoursOnWeekends"));
            }
        }

        private IWebElement CrudLink
        {
            get
            {
                return _driver.FindElement(By.Id("crudLink"));
            }
        }


        private IWebElement Savings
        {
            get
            {
                return _driver.FindElement(By.Id("savings"));
            }
        }


        private IWebElement Account
        {
            get
            {
                return _driver.FindElement(By.Id("account"));
            }
        }



        private IWebElement Chain
        {
            get
            {
                return _driver.FindElement(By.Id("chain"));
            }
        }


        private IWebElement CPFRecipient
        {
            get
            {
                return _driver.FindElement(By.Id("cpfRecipient"));
            }
        }


        private IWebElement BankName
        {
            get
            {
                return _driver.FindElement(By.Id("bankName"));
            }
        }


        private IWebElement Agency
        {
            get
            {
                return _driver.FindElement(By.Id("agency"));
            }
        }

        private IWebElement Recipient
        {
            get
            {
                return _driver.FindElement(By.Id("recipient"));
            }
        }

        private IWebElement Salary
        {
            get
            {
                return _driver.FindElement(By.Id("salary"));
            }
        }


        private IWebElement BtnSave
        {
            get
            {
                return _driver.FindElement(By.Id("btnSave"));
            }
        }

        private IWebElement BtnBank
        {
            get
            {
                return _driver.FindElement(By.Id("pills-bank-tab"));
            }
        }

        private IWebElement BtnKnow
        {
            get
            {
                return _driver.FindElement(By.Id("pills-knowledge-tab"));
            }
        }

        public void Save(CandidateViewModel candidate)
        {
            FillCandidate(candidate);
            BtnSave.Click();
        }

        public void FillCandidate(CandidateViewModel candidate)
        {
            Name.EnterText(candidate.Name);
            Email.EnterText(candidate.Email);
            CrudLink.EnterText(candidate.CrudLink);
            SkypeAddress.EnterText(candidate.SkypeAddress);
            Portfolio.EnterText(candidate.Portfolio);
            State.EnterText(candidate.State);
            City.EnterText(candidate.City);
            Cellphone.EnterText(candidate.Cellphone);
            SixEightHours.Click();
            Salary.EnterText(candidate.Salary.ToString());
            BtnBank.Click();
            FillBank(candidate);
            BtnKnow.Click();
            _knowledgePage.FillKnowledge(candidate);
        }

        public void FillBank(CandidateViewModel candidate)
        {
            Account.EnterText(candidate.Account);
            Chain.Click();
            Recipient.EnterText(candidate.Recipient);
            CPFRecipient.EnterText(candidate.CPFRecipient);
            BankName.EnterText(candidate.BankName);
            Account.EnterText(candidate.Account);
        }

        
    }
}
