using FamilyTree.Data.Models;
using System;
using System.Runtime.Serialization;

namespace FamilyTree.Data.Dto
{
    public class PersonDto : EntityDto
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name of the patronymic.
        /// </summary>
        /// <value>
        /// The name of the patronymic.
        /// </value>
        [DataMember]
        public string PatronymicName { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>
        /// The birth date.
        /// </value>
        [DataMember]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the death date.
        /// </summary>
        /// <value>
        /// The death date.
        /// </value>
        [DataMember]
        public DateTime? DeathDate { get; set; }

        /// <summary>
        /// Gets or sets the biography.
        /// </summary>
        /// <value>
        /// The biography.
        /// </value>
        [DataMember]
        public string Biography { get; set; }

        /// <summary>
        /// Gets or sets the gender identifier.
        /// </summary>
        /// <value>
        /// The gender identifier.
        /// </value>
        [DataMember]
        public int GenderId { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public GenderDto Gender { get; set; }

        public PersonDto()
        {
        }

        public PersonDto(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            PatronymicName = person.PatronymicName;
            BirthDate = person.BirthDate;
            DeathDate = person.DeathDate;
            Biography = person.Biography;
            GenderId = person.GenderId;
            Gender = new GenderDto(person.Gender);
        }
    }
}