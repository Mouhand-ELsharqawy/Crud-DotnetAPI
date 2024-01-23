using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Crud.Data.dto
{
    public class Userdto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
