using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashColletctor.Models
{
    public class Customer
    {
        [Key]
        public string fristName { get; set; }
        public string lastName { get; set; }
        public int Zipcode { get; set; }
        public int PhoneNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Address { get; set; }
        

    }
    public class Employee
    {
        [Key]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int emplyeeId { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
    public class PickUp
    {
    }
}