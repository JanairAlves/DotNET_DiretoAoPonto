using DevFreela.Application.Commands.UpdateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotNull()
                .NotEmpty()
                .MaximumLength(30);

            RuleFor(p => p.Description)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100);
                
        }
    }
}
