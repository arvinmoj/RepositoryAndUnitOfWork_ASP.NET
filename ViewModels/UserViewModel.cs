using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class UserViewModel : object
    {
        public UserViewModel() : base()
        {
        }

        [Required]
        [Display(Name = "FullName")]
        [MaxLength(length: Models.Constant.Length.FULL_NAME)]
        public string FullName { get; set; }
        
        [Required]
        [Display(Name = "Gender")]
        [MaxLength(length: Models.Constant.Length.GENDER)]
        public string Gender { get; set; }

    }
}