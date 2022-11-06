using Microsoft.EntityFrameworkCore;
using PhoneBook.Model.People.Entities;
using PhoneBook.Model.Phones.Entities;
using PhoneBook.Model.Tags.Entities;

namespace PhoneBook.DAL.DbContexts;

public class PhoneBookContext : DbContext
{
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<PersonTag> PersonTags { get; set; }
    public DbSet<Phone> phones { get; set; }

    public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

    }
}
