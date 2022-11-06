using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Model.Phones.Entities;

namespace PhoneBook.DAL.Phones;

public class PhoneConfig : IEntityTypeConfiguration<Phone>
{
    public void Configure(EntityTypeBuilder<Phone> builder)
    {
        builder.Property(c => c.PhoneNumber).HasMaxLength(20);
    }
}
