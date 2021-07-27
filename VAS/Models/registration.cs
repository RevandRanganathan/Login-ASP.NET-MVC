//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class registration
    {

        [Required(ErrorMessage ="Field Need not to be Empty")]
        public int id { get; set; }
        [Required(ErrorMessage = "Field Need not to be Empty")]
        
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Field Need not to be Empty")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Field Need not to be Empty")]
        [EmailAddress(ErrorMessage ="Must be a Valid EmailAddress")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field Need not to be Empty")]

        public string Address { get; set; }
    }
}