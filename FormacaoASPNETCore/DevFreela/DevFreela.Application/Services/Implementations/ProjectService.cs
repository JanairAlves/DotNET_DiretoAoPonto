using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewProjectInputModel inputModel)
        {
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);
            _dbContext.Projects.Add(project);

            return project.Id;
        }

        public void CreateComment(CreateCommetInputModel inputModel)
        {
            var comment = new ProjectComment(inputModel.Content, inputModel.IdProject, inputModel.IdUser);
            _dbContext.ProjectComments.Add(comment);
        }

        public void Delete(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id ==id);
            project.Cancel();
        }

        public void Finish(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            throw new System.NotImplementedException();
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Start(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
