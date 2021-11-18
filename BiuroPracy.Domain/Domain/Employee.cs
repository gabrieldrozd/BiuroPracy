using BiuroPracy.Domain;
using System;

namespace BiuroPracy.Domain
{
    public class Employee
    {
        public virtual int Id { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual DateTime? DateOfBirth { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual Profession Profession { get; set; }
    }
}
