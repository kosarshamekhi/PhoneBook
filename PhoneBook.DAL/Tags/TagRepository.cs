using PhoneBook.DAL.DbContexts;
using PhoneBook.Model.Tags.Entities;

namespace PhoneBook.DAL.Tags;

public class TagRepository : ITagRepository 
{
    private readonly PhoneBookContext _phoneBookContext;

    public TagRepository(PhoneBookContext phoneBookContext)
    {
        _phoneBookContext = phoneBookContext;
    }
    public void AddTag(Tag tag)
    {
        _phoneBookContext.Tags.AddAsync(tag);
        _phoneBookContext.SaveChangesAsync();
    }
}
