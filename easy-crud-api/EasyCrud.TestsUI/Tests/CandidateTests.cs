using EasyCrud.TestsUI.PageObject;
using EasyCrud.TestsUI.PageObjects;
using EasyCrud.ViewModels;
using Xunit;

namespace EasyCrud.TestsUI.PageObjects
{
    public class CandidateTests : SeleniumBase
    {
        private readonly CandidatePage candidatePageObject;
        private readonly CommonPage commonPage;
        public CandidateTests()
        {
            driver.Navigate().GoToUrl(url);
            candidatePageObject = new CandidatePage(driver);
            commonPage = new CommonPage(driver);
        }

        [Fact]
        public void SaveCandidateSuccess()
        {
            CandidateViewModel candidate = new CandidateViewModel()
            {
                Name = "Joaquim",
                Email = "Joaquim@gmail.com",
                CPFRecipient = "44166763871",
                BankName = "ITAU",
                Account = "3200",
                Agency = "000000",
                Cellphone = "999999999",
                CrudLink = "github.com.br",
                City = "São Paulo",
                Html = 4,
                Asp = 5,
                Java = 5,
                MySql = 5,
                Ionic = 2,
                Others = "React js , angular js , entity framework",
                State = "SP",
                SqlServer = 5,
                SkypeAddress = "joaquim.skype",
                Chain = true,
                Recipient = "Joaquim",
                Portfolio = "github",
                Salary = 6000
            };

            candidatePageObject.Save(candidate);
        } 
    }
}
