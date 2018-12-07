//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Week7Assessment6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Guest
    {   [Key]
        public int GuestID { get; set; }
        [Required(ErrorMessage = "Please enter your first name"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Attendance Date"), DataType(DataType.DateTime)]
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        [Required(ErrorMessage = "Please enter your e-mail address"), Display(Name = "E-mail"), DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Display(Name = "Will you be bringing a guest?")]
        public string Guest1 { get; set; }
        [Display(Name = "Attending?"), NotMapped]
        public string Attending { get; set; }
        [Display(Name = "Guest Name"), NotMapped]
        public string GuestName { get; set; }
    }
}
