using BlueTicket.Domain.Common;
using BlueTicket.Domain.Enum;
using System;

namespace BlueTicket.Domain.Entities
{
    public class Person : AuditableEntity
    {
        public int PersonId { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public bool Active { get; set; }
    }
}
