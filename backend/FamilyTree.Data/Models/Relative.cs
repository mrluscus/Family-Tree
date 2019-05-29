using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Data.Models
{
    [Table("Relative")]
    public class Relative : Entity
    {
        [ForeignKey("Person")]
        public int Person1Id { get; set; }

        public Person Person1 { get; set; }

        [ForeignKey("Person")]
        public int Person2Id { get; set; }

        public Person Person2 { get; set; }

        [ForeignKey("RelativeType")]
        public int RelativeTypeId { get; set; }

        public RelativeType RelativeType { get; set; }
    }
}