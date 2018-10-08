using EasyCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCrud.Context
{
    public class Seed
    {
        private readonly ApplicationDbContext _context;

        public Seed(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SeedDB()
        {
            _context.Database.EnsureCreated();


            var candidate = new Candidate()
            {
                Name = "Walter",
                Email = "walter.vlopes@gmail.com",
                Cellphone = "9582857090",
                LinkedinAddress = "linkedin.com/walter-cardoso",
                CrudLink = "github.com/walter-lopes",
                Portfolio = "github.com/walter-lopes",
                Comercial = true,
                Account = "123123",
                CPFRecipient = "44166763871",
                BankName = "ITAU",
                Agency = "1111",
                Salary = 6000,
                State = "SP",
                City = "SÃO PAULO",
                Chain = true,
                EightHours = true,
                SkypeAddress = "walter_guga@hotmail.com",
                Recipient = "Walter V L Cardoso",
            };

            var knowledge = new Knowledge()
            {
                Ionic = 4,
                Asp = 5,
                Angular = 4,
                Bootstrap = 4,
                Cplusplus = 3,
                SqlServer = 5,
                Others = "react js| nodejs",
                Android = 2,
                Html = 4,
                Css = 4,
                Java = 3,
                Jquery = 4,
                MySql = 2,
                Seo = 2,
                Candidate = candidate
            };
          //  _context.Add(candidate);
            _context.Add(knowledge);
            _context.SaveChanges();

        }
    }
}
