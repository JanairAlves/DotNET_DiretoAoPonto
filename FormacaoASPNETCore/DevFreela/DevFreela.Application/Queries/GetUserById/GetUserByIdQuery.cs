using DevFreela.Application.ViewModels;
using MediatR;

namespace DevFreela.Application.Queries.GetUserById
{
    public class GetUserByIdQuery : IRequest<UserDetailsViewModel>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
