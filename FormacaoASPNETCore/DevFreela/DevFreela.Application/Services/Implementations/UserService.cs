using DevFreela.Application.InputModels;
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
                .Select(u => new UserDetailsViewModel(u.Id, u.FullName, u.Email, u.BirthDate, u.CreatedAt, u.Active))
                .ToList();

            return usersViewModel;

        }

        public UserDetailsViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);
            var userDetailsViewModel = new UserDetailsViewModel(
                user.Id,
                user.FullName,
                user.Email,
                user.BirthDate,                
                user.CreatedAt,
                user.Active
                );

            return userDetailsViewModel;
        }
    }
}
