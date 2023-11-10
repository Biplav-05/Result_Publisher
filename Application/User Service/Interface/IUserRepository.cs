
using Domain.Entities;
using Domain.Model.User_Model;

namespace Application.User_Service.Interface
{
    public interface IUserRepository
    {
        Task<User> RegisterUserAsync(RegisterUserModel model);
    }
}
