using System.Threading.Tasks;
using SocialMediaData.Models;
namespace SocialMediaBusiness.Interface
{
    public interface IUserManager
    {
       string RegisterUserAsync(string email, string password);  
    }
}