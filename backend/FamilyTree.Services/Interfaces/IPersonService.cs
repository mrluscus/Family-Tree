using FamilyTree.Data.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FamilyTree.Services.Interfaces
{
    public interface IPersonService
    {
        /// <summary>
        /// Gets all Persons.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<List<PersonDto>> GetAllAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the Person by id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<PersonDto> GetAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves the Person.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<int> SaveAsync(PersonDto item, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the Person.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the List of Persons.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(List<int> ids, CancellationToken cancellationToken = default);
    }
}