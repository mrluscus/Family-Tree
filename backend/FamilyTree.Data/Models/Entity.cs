using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Data.Models
{
  /// <summary>
  /// Base class for entities
  /// </summary>
  public abstract class Entity
  {
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
  }
}