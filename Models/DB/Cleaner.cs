using System;
using System.Collections.Generic;

#nullable disable

namespace CENG382.Models.DB
{
    public partial class Cleaner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsActive { get; set; }
    }
}
