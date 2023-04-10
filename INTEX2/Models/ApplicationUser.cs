using Microsoft.AspNetCore.Identity;
using INTEX2.Models;
using System.ComponentModel.DataAnnotations;

namespace INTEX2.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}