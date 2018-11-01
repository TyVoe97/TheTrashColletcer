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
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Zipcode")]
        public int Zipcode { get; set; }
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        

    }
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = " First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Employee Id")]
        public int emplyeeId { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }

    }
    public class PickUp
    {
    }
}