using FluentValidation;
using MediatR;
using UsingMediatrCQRS.Commands;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Behaviour
{
    public class ValidationBehaviour : IPipelineBehavior<RegisterPersonCommand, Person>
    {
        private readonly IValidator<RegisterPersonCommand> _validator;

        public ValidationBehaviour(IValidator<RegisterPersonCommand> validator)
        {
            _validator = validator;
        }

        public async Task<Person> Handle(
            RegisterPersonCommand request,
            RequestHandlerDelegate<Person> next,
            CancellationToken cancellationToken
        )
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.IsValid)
            {
                return await next();
            }

            throw new Exception("Invalid Input");
        }
    }
}
