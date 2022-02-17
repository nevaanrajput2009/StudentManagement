using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please Enter Roll Number.")]
        public int RollNumber { get; set; }

        [Required(ErrorMessage = "Please Enter First Name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Select the Gender..")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
    }
}
