using PhoneBook.Model.Framework;
using PhoneBook.Model.Phones.Entities;

namespace PhoneBook.Model.People.Entities;

public class Person : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Image { get; set; }
    public List<Phone> Phones { get; set; }
    public List<PersonTag> Tags { get; set; }
}
