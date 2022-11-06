using MediatR;
using PhoneBook.DAL.Tags;
using PhoneBook.Model.Framework;
using PhoneBook.Model.Tags.Commands;
using PhoneBook.Model.Tags.Entities;

namespace PhoneBook.BLL.Tags.Commands;

public class CreateTagAppServise : IRequestHandler<CreateTagInput, AppServiseResponse<CreateTagOutput>>
{
    private readonly TagRepository _tagRepository;

    public CreateTagAppServise(TagRepository tagRepository)
    {
        _tagRepository = tagRepository;
    }

    public async Task<AppServiseResponse<CreateTagOutput>> Handle(CreateTagInput createTagInput, CancellationToken cancellationToken)
    {
        var newTag = new Tag
        {
            Title = createTagInput.TagName,
        };

        _tagRepository.AddTag(newTag);

        return new AppServiseResponse<CreateTagOutput>
        {
            Result = new CreateTagOutput() { TagId = newTag.Id }
        };
    }
}
