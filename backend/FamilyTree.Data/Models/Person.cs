using FamilyTree.Data.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.Data.Models
{
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

    public Person(string firstName, string lastName, string patronymicName, string biography, int genderId, Gender gender)
    {
      this.FirstName = firstName;
      this.LastName = lastName;
      this.PatronymicName = patronymicName;
      this.Biography = biography;
      this.GenderId = genderId;
      this.Gender = gender;
    }
  }
}