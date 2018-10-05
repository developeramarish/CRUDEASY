using System;

namespace EasyCrud.Domain.Entities
{
    public class Candidate
    {
		public Guid Id { get; set; }

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

        public string Recipient { get; set; }

        //Bank

        public string CPFRecipient { get; set; }

        public string BankName { get; set; }

        public string Agency { get; set; }

        public string Account { get; set; }

        public bool Chain { get; set; }

        public bool Savings { get; set; }


        public Guid KnowledgeId { get; set; }

		public virtual Knowledge Knowledge { get; set; }
	}
}
