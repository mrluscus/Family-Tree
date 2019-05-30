using FamilyTree.Data.Models;

namespace FamilyTree.Data.Dto
{
    public class GenderDto : EntityDto
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        public GenderDto(Gender gender)
        {
            Code = gender.Code;
            Name = gender.Name;
        }
    }
}