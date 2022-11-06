using MediatR;
using PhoneBook.Model.Framework;

namespace PhoneBook.Model.Tags.Commands;

public class CreateTagInput : IRequest<AppServiseResponse<CreateTagOutput>>
{
    public string TagName { get; set; }
}
