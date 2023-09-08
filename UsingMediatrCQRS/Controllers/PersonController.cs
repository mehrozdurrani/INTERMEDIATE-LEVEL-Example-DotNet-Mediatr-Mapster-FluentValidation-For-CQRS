using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsingMediatrCQRS.Commands;
using UsingMediatrCQRS.Contracts;
using UsingMediatrCQRS.DataStore;
using UsingMediatrCQRS.Notifications;
using UsingMediatrCQRS.Queries;

namespace UsingMediatrCQRS.Controllers
{
    [Route("person")]
    public class PersonController : ApiController
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator, DummyDataStore dummyDataStore)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> ListPersons()
        {
            var result = await _mediator.Send(new GetAllPersonsQuery());
            return Ok(result);
        }

        [HttpGet("{personId}")]
        public async Task<IActionResult> GetPerson(int personId)
        {
            var result = await _mediator.Send(new GetPersonByIdQuery(Id: personId));
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterPerson(RegisterRequest request)
        {
            var result = await _mediator.Send(
                new RegisterPersonCommand(FirstName: request.FirstName, LastName: request.LastName)
            );
            await _mediator.Publish(new PersonRegisterNotification(result));
            return Ok(result);
        }
    }
}
