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

        }

        public void Delete(int id)
        {

        }
    }
}
