using Application.User_Service.Interface;
using Domain.Entities;
using Domain.Model.User_Model;

namespace Infrastructure.Persistence.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RMS_Dbcontext _dbcontext;
        public UserRepository(RMS_Dbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task<User> RegisterUserAsync(RegisterUserModel model)
        {
            var user = new User
            {
                user_Id = Guid.NewGuid(),
                firstName = model.firstName,
                lastName = model.lastName,
                email = model.email,
                password = model.password,
            };
            await _dbcontext.AddRangeAsync(user);
            await _dbcontext.SaveChangesAsync();
            return  user;
            
            


        }
    }
}
