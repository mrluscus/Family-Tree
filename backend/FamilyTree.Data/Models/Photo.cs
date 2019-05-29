using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Data.Models
{
    [Table("Photo")]
    public class Photo : Entity
    {
        [Required]
        public string Path { get; set; }

        public string Description { get; set; }
    }
}