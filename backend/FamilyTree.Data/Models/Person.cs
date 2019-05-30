using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Data.Models
{
    [Table("Person")]
    public class Person : Entity
    {
        public string FirstName { get; set; }
         
        public string LastName { get; set; }

        public string PatronymicName { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? DeathDate { get; set; }

        public string Biography { get; set; }

        [ForeignKey("Gender")]
        public int GenderId { get; set; }

        public Gender Gender { get; set; }
    }
}