using Domain.Entities;
using Domain.Model.User_Model;

namespace Application.User_Service.Interface
{
    public interface IUserService
    {
        public Task<User> RegisterUserAsync(RegisterUserModel model);
    }
}
