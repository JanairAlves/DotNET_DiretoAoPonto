using DevFreela.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace DevFreela.Application.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<List<UserViewModel>>
    {
        public GetAllUsersQuery(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}
