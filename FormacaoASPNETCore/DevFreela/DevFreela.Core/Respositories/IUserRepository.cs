using DevFreela.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevFreela.Core.Respositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task AddAsync(User user);
        Task SaveChangesAsync();
    }
}
