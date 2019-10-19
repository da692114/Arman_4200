using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Arman_4200.Models
{
    
    public partial class Student
    {

        
        public int studentID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Student first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Student last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", 
        ErrorMessage ="Phone numbers must be in format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Student Since")]
        [Required]
        public DateTime studentSince { get; set; }

        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)

        public ICollection<Course> Course { get; set; }

    }
}