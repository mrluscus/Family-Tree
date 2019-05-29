using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Data.Models
{
    [Table("Gender")]
    public class Gender : Entity
    {
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}