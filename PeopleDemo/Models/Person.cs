using System;
using System.ComponentModel.DataAnnotations;

namespace PeopleDemo.Models
{
    public class Person
    {
        public int ID { get; set; }
        [StringLength(15, ErrorMessage = "First name must be <= 20 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        [DisplayFormat(DataFormatString = "{0: MMM dd, yyyy}")]
        public DateTime BirthDate { get; set; }
    }

}
