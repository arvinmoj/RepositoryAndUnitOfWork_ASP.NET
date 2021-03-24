using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("User")]
    public class User : Base.Entity
    {
        public User() : base()
        {
        }
        
        // *****
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        // *****
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        // *****


        // // *****
        // [Required]
        // [Display(Name = "UserNumber")]
        // public int UserNumber { get; set; }
        // // *****

        // // *****
        // [Required]
        // [MaxLength(64)]
        // [DataType(DataType.Text)]
        // [Display(Name = "UserName")]
        // public string UserName { get; set; }
        // // *****

        // // *****
        // [Required]
        // [MaxLength(256)]
        // [DataType(DataType.Text)]
        // [Display(Name = "Password")]
        // public string Password { get; set; }
        // // *****
    }
}