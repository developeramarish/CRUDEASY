
using NETCore.DapperKit.Extensions;
using System;

namespace Crud.Easy.Domain.Entities
{
    public class Candidate
    {
        [Key]
        public long CandidateId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string SkypeAddress { get; set; }

        public string Cellphone { get; set; }

        public string LinkedinAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Portfolio { get; set; }

        public bool FourHours { get; set; }

        public bool FourSixHours { get; set; }

        public bool SixEightHours { get; set; }

        public bool EightHours { get; set; }

        public bool HoursOnWeekends { get; set; }

        public bool Morning { get; set; }

        public bool Afternoon { get; set; }

        public bool Night { get; set; }

        public bool Dawn { get; set; }

        public bool Comercial { get; set; }

        public int Salary { get; set; }
   
        public string CrudLink { get; set; }

        public long KnowledgementId { get; set; }

        public long BankId { get; set; }

        [Write(false)]
        public Knowledgement Knowledgement { get; set; }

        [Write(false)]
        public Bank Bank { get; set; }

        public Candidate()
        {
           
        }

        public bool EmailIsValid()
        {
            return this.Email.Contains("@");
        }

        public bool IsValid()
        {
            return EmailIsValid() && Bank.CPFIsValid();
        }
    }
}
