using Application.User_Service.Interface;
using Domain.Entities;
using Domain.Model.User_Model;

namespace Application.User_Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> RegisterUserAsync(RegisterUserModel model)
        {
            return await _userRepository.RegisterUserAsync(model);
        }
    }
}
