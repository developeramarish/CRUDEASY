using EasyCrud.Domain.Entities;
using EasyCrud.Domain.Validators;
using Xunit;

namespace EasyCrud.UnitTests.Validators

{
    public class CandidateTests
    {

        CandidateValidator validator = new CandidateValidator();


        [Fact]
        public void ValidEntities()
        {
            Candidate candidate = new Candidate()
            {
                   Name = "Walter",
                   Email = "walter.vlopes@gmail.com",
                   CPFRecipient = "4166763873",
                   CrudLink = "www.github.com\\walter",
                   Portfolio = "www.github.com\\walter",
                   Cellphone = "999999999"
            };

            var result = validator.Validate(candidate);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void InvalidEntities()
        {
            Candidate candidate = new Candidate()
            {
                Name = "Walter",
                Email = "walter.vlopes.com",
                CPFRecipient = "4166763873",
                CrudLink = "www.github.com\\walter",
                Portfolio = "www.github.com\\walter"
            };

            var result = validator.Validate(candidate);

            Assert.False(result.IsValid);
        }
    }
}
