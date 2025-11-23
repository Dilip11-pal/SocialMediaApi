using System;
using SocialMediaData.Models;
using System.Collections.Generic;

namespace SocialMediaData.Repository.Interface
{
    public interface IUserRepository
    {
       string GetByEmail(string email);
       
    }
}
