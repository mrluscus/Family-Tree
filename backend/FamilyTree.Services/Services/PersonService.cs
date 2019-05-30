using FamilyTree.Data;
using FamilyTree.Data.Dto;
using FamilyTree.Data.Models;
using FamilyTree.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FamilyTree.Services.Services
{
    public class PersonService : IPersonService
    {
        private readonly ILogger<PersonService> _logger;
        private readonly FamilyTreeDbContext _dbContext;

        public PersonService(FamilyTreeDbContext dbContext,
            ILogger<PersonService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        /// <summary>
        /// Gets all Persons.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<List<PersonDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Persons
                .Select(x => new PersonDto(x))
                .ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Gets the Person by id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<PersonDto> GetAsync(int id, CancellationToken cancellationToken = default)
        {
            var item = await _dbContext.Persons.FindAsync(id);

            return item == null ? null : new PersonDto(item);
        }

        /// <summary>
        /// Saves the Person.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<int> SaveAsync(PersonDto item, CancellationToken cancellationToken = default)
        {
            try
            {
                var dbSet = _dbContext.Persons;
                var itemFromDb = dbSet.Find(item.Id);
                if (itemFromDb != null)
                {
                    itemFromDb.Biography = item.Biography;
                    itemFromDb.BirthDate = item.BirthDate;
                    itemFromDb.DeathDate = item.DeathDate;
                    itemFromDb.FirstName = item.FirstName;
                    itemFromDb.GenderId = item.GenderId;
                    itemFromDb.LastName = item.LastName;
                    itemFromDb.PatronymicName = item.PatronymicName;

                    dbSet.Update(itemFromDb);
                }
                else
                {
                    itemFromDb = new Person
                    {
                        Biography = item.Biography,
                        BirthDate = item.BirthDate,
                        DeathDate = item.DeathDate,
                        FirstName = item.FirstName,
                        GenderId = item.GenderId,
                        LastName = item.LastName,
                        PatronymicName = item.PatronymicName
                    };

                    dbSet.Add(itemFromDb);
                }

                await _dbContext.SaveChangesAsync(cancellationToken);
                return item.Id;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return -1;
        }

        /// <summary>
        /// Deletes the Person.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            try
            {
                var dbSet = _dbContext.Persons;
                var entity = dbSet.Find(id);
                if (entity != null)
                {
                    dbSet.Remove(entity);
                    await _dbContext.SaveChangesAsync(cancellationToken);
                    return true;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return false;
            }

            return false;
        }

        /// <summary>
        /// Deletes the List of Persons.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(List<int> ids, CancellationToken cancellationToken = default)
        {
            var dbSet = _dbContext.Persons;
            foreach (var id in ids)
            {
                var entity = dbSet.Find(id);
                if (entity != null)
                {
                    dbSet.Remove(entity);
                }
            }

            try
            {
                await _dbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return false;
            }
        }
    }
}