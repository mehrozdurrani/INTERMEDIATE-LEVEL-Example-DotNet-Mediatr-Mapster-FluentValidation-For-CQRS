using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsingMediatrCQRS.Commands;
using UsingMediatrCQRS.Contracts;
using UsingMediatrCQRS.DataStore;
using UsingMediatrCQRS.Model;
using UsingMediatrCQRS.Notifications;
using UsingMediatrCQRS.Queries;

namespace UsingMediatrCQRS.Controllers
{
    [Route("person")]
    public class PersonController : ApiController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public PersonController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
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
            var commmand = _mapper.Map<RegisterPersonCommand>(request);
            var result = await _mediator.Send(commmand);
            List<NotificationEvent> eventsOccured = new();
            await _mediator.Publish(new PersonRegisterNotification(result, eventsOccured));

            return Ok(result);
        }
    }
}
