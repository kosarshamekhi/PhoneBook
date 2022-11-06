using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Model.People.Entities;

namespace PhoneBook.DAL.People;

public class PersonTagConfig : IEntityTypeConfiguration<PersonTag>
{
    public void Configure(EntityTypeBuilder<PersonTag> builder)
    {
        
    }
}
