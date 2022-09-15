using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetProjectById
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQuery>
    {
        private readonly DevFreelaDbContext _dbContext;
        public GetProjectByIdQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Unit> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects
                .Include(p => p.Client)
                .Include(p => p.Freelancer)
                .SingleOrDefault(p => p.Id == request.Id);

            if (project == null) return null;

            var projectDetailsViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.Description,
                project.TotalCost,
                project.CreatedAt,
                project.StartedAt,
                project.FinishedAt,
                project.Client.FullName,
                project.Freelancer.FullName);

            return projectDetailsViewModel;
        }
    }
}
