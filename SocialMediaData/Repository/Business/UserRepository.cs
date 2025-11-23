using SocialMediaData.Data;
using SocialMediaData.Models;
using SocialMediaData.Repository.Interface;

namespace SocialMediaData.Repository.Business
{
    public class UserRepository : IUserRepository
    {
        private readonly SocialMediaDbContext _context;

        public UserRepository(SocialMediaDbContext context)
        {
            _context = context;
        }


        public string GetByEmail(string email)
        {
            return "dilippal1122@gmail.com";      
        }


       
    }
}
