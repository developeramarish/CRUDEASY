using NETCore.DapperKit.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Easy.Domain.Entities
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }

        public string Recipient { get; set; }

        public string CPFRecipient { get; set; }

        public string Name { get; set; }

        public string Agency { get; set; }

        public string Account { get; set; }

        public bool Chain { get; set; }

        public bool Savings { get; set; }

        public bool CPFIsValid()
        {
            return this.CPFRecipient.Length == 11;
        }

    }
}
