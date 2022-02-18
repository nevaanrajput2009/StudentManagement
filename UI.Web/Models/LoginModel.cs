using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class LoginModel
    {
        /// <summary>
        /// User Name for login
        /// </summary>
        /// 
        [Required(ErrorMessage = "Please enter user name")]
        public string UserName { get; set; }

        /// <summary>
        /// Password for login
        /// </summary>
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
    }
}
