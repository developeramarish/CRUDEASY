
using NETCore.DapperKit.Extensions;
using System;

namespace Crud.Easy.Domain.Entities
{
    public class Customer
    {
        [Key]
        public long CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public DateTime RegisterDate { get; set; }

        public Customer()
        {
            RegisterDate = DateTime.Now;
        }

        public bool IsSpecial()
        {
            return DateTime.Now.Year -  RegisterDate.Year   >  5;
        }


        public bool EmailIsValid()
        {
            return this.Email.Contains("@");
        }

        public bool CPFIsValid()
        {
            return this.CPF.Length == 11;
        }

        public bool IsValid()
        {
            return EmailIsValid() && CPFIsValid();
        }
    }
}
