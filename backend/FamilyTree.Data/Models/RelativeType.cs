using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Data.Models
{
    [Table("RelativeType")]
    public class RelativeType : Entity
    {
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}