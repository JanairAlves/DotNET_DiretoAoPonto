using DevFreela.Application.Commands.CreateProjectComment;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommentCommandValidator : AbstractValidator<CreateProjectCommentCommand>
    {
        public CreateProjectCommentCommandValidator()
        {
            RuleFor(c => c.Content)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);
        }
    }
}
