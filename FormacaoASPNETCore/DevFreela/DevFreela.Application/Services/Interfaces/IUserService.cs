using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;
using System.Collections.Generic;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        List<UserDetailsViewModel> GetAll(string query);
        UserDetailsViewModel GetById(int id);
    }
}
