using ProjectManager.Models.Contracts;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectManager.Models
{
    public class User : IUser
    {
        [Required]
        private const string UserNameIsRequiredErrorMessage = "User Username is required!";
        
        [Required]
        private const string UserEmailIsRequiredErrorMessage = "User Email is required!";

        [EmailAddress]
        private const string UserEmailIsNotValidErrorMessage = "User Email is not valid!";
        

        public User(string username, string email)
        {
            this.UserName = username;
            this.Email = email;
        }

        public string UserName { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine("    Username: " + this.UserName);
            builder.AppendLine("    Email: " + this.Email);

            return builder.ToString();
        }
    }
}
