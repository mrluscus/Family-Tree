using FamilyTree.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Data
{
    public class FamilyTreeDbContext : DbContext
    {
        public FamilyTreeDbContext(DbContextOptions<FamilyTreeDbContext> options) : base(options)
        {
        }

        public DbSet<Gender> Genders { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhotoPerson> PhotoPersons { get; set; }
        public DbSet<Relative> Relatives { get; set; }
        public DbSet<RelativeType> RelativeTypes { get; set; }
    }
}