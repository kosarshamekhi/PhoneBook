using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Model.Tags.Commands;
using PhoneBook.WebUI.Framework;

namespace PhoneBook.WebUI.Controllers;

public class TagController : BaseController
{
    public TagController(IMediator mediator) : base (mediator)
    {
    }

    //public IActionResult Index()
    //{
    //    return View();
    //}

    [HttpGet]

    public async Task<IActionResult> CreateCount(CreateTagInput createTagInput)
    {
        var response = await _mediator.Send(createTagInput);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    //[HttpPost]
    //public IActionResult AddTag()
    //{

    //}
}
