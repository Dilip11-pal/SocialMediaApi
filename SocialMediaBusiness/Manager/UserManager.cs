using System.Threading.Tasks;
using SocialMediaBusiness.Interface;
using SocialMediaData.UnitofWork;
namespace SocialMediaBusiness.Manager
{
public class UserManager : IUserManager
{
    private readonly UnitOfWork _unitOfWork;

    public UserManager(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public string RegisterUserAsync(string email, string password)
    {
        var existingUser = _unitOfWork.UserRepository.GetByEmail(email);
      return existingUser;

       

        
    }
}
}
