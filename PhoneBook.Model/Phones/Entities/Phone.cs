using PhoneBook.Model.Framework;

namespace PhoneBook.Model.Phones.Entities;

public class Phone : BaseEntity
{
    public string PhoneNumber { get; set; }
    public string PhoneType { get; set; }
}
