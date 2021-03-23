using System.ComponentModel.DataAnnotations;

namespace Models.Enums
{
    public enum Gender : int
    {
        [Display(Name = "Female")]
        Female = 0 , 

        [Display(Name = "Male")]
        Male = 1 ,

        [Display(Name = "Non-Binary")]
        NonBinary = 2 ,
    }
}