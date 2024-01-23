using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.Data.Model
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        
        public string Description { get; set; }

        
        public int UserId { get; set; }

       
    }
}
