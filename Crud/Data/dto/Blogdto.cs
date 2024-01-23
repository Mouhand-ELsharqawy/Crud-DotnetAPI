using Crud.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Crud.Data.dto
{
    public class Blogdto
    {
       
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }
        [Required]
        public int UserId { get; set; }

    }
}
