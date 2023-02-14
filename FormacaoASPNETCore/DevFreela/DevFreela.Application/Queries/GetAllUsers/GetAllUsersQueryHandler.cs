using DevFreela.Application.Queries.GetUserById;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Respositories;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserViewModel>>
    {
        private readonly IUserRepository _userRepository;
        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllAsync();

            var usersViewModel = users
                .Select(u => new UserViewModel(u.Id, u.FullName, u.Active))
                .ToList();

            return usersViewModel;
        }
    }
}
