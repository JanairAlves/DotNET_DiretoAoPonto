using DevFreela.Core.Entities;
using DevFreela.Core.Respositories;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CreateProjectComment
{
    public class CreateCommentCommandHadler : IRequestHandler<CreateCommentCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
        public CreateCommentCommandHadler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var projectComment = new ProjectComment(request.Content, request.IdProject, request.IdUser);

            await _projectRepository.AddCommentAsync(projectComment);

            return Unit.Value;
        }
    }
}
