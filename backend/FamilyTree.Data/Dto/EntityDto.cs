using System;
using System.Runtime.Serialization;

namespace FamilyTree.Data.Dto
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    [DataContract]
    public abstract class EntityDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
        public int Id { get; set; }
    }
}