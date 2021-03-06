using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Data.Models
{
    [Table("Person")]
    public class Person : Entity
    {
        public Person()
        {
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name of the patronymic.
        /// </summary>
        /// <value>
        /// The name of the patronymic.
        /// </value>
        public string PatronymicName { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>
        /// The birth date.
        /// </value>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the death date.
        /// </summary>
        /// <value>
        /// The death date.
        /// </value>
        public DateTime? DeathDate { get; set; }

        /// <summary>
        /// Gets or sets the biography.
        /// </summary>
        /// <value>
        /// The biography.
        /// </value>
        public string Biography { get; set; }

        /// <summary>
        /// Gets or sets the gender identifier.
        /// </summary>
        /// <value>
        /// The gender identifier.
        /// </value>
        [ForeignKey("Gender")]
        public int GenderId { get; set; }
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public Gender Gender { get; set; }
    }
}