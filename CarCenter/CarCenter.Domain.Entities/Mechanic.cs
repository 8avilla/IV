using System;
using static CarCenter.Common.Enums.MechanicEnum;

namespace CarCenter.Domain.Entities
{
    public class Mechanic
    {
        public  string DocumentType { get; set; }
        public  string DocumentNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public string TelePhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public MechanicStatus Status { get; set; }
    }
}
