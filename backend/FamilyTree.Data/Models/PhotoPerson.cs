using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Data.Models
{
  public class PhotoPerson : Entity
  {
    [ForeignKey("Person")]
    public int PersonId { get; set; }
    public Person Person { get; set; }

    [ForeignKey("Photo")]
    public int PhotoId { get; set; }
    public Photo Photo { get; set; }
  }
}