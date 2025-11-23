using SocialMediaData.Data;
using SocialMediaData.Repository.Interface;
using SocialMediaData.Repository.Business;
namespace SocialMediaData.UnitofWork
{
    public class UnitOfWork
    {
        private readonly SocialMediaDbContext _context;
        private IUserRepository? _userRepository;

        public UnitOfWork(SocialMediaDbContext context)
        {
            _context = context;
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);
                }
                return _userRepository;
            }
        }
    }
}