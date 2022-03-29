using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<UserDetailsViewModel> GetAll(string query)
        {
            var users = _dbContext.Users;
            var usersViewModel = users
                .Select(u => new UserDetailsViewModel(u.Id, u.Fullname, u.Email, u.BirthDate, u.CreatedAt, u.Active))
                .ToList();

            return usersViewModel;

        }

        public UserDetailsViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);
            var userDetailsViewModel = new UserDetailsViewModel(
                user.Id,
                user.Fullname,
                user.Email,
                user.BirthDate,                
                user.CreatedAt,
                user.Active
                );

            return userDetailsViewModel;
        }

        public int Create(NewUserInputModel inputModel)
        {
            var user = new User(inputModel.Fullname, inputModel.Email, inputModel.BirthDate);
            _dbContext.Users.Add(user);

            return user.Id;
        }

        public void Update(UpdateUserInputModel inputModel)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == inputModel.Id);

            user.Update(inputModel.Fullname, inputModel.Email, inputModel.BirthDate , inputModel.Active);
        }

        public void Delete(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);
            user.Cancel();
        }
    }
}
