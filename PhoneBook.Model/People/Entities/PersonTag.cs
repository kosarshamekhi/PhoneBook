using PhoneBook.Model.Framework;
using PhoneBook.Model.Tags.Entities;

namespace PhoneBook.Model.People.Entities;

public class PersonTag:BaseEntity
{
    public int TagId { get; set; }
    public Tag Tag { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
}
