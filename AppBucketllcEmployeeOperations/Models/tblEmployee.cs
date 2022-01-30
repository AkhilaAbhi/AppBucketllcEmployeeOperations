//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppBucketllcEmployeeOperations.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblEmployee
    {
        public int EmpId { get; set; }

        [Required(ErrorMessage = "First Name is Mandatory")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Mandatory")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telephone Number is Mandatory")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Department is Mandatory")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Designation is Mandatory")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Mobile Number is Mandatory")]
        [Range(10000, 100000000,ErrorMessage = "Salary must be between 10000 and 100000000")]
        public Nullable<long> Salary { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public System.DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
