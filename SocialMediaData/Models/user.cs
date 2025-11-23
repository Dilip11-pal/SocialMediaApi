using System;
namespace SocialMediaData.Models
{
    public class User:BaseEntity
    {
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public string? ProfilePictureUrl { get; set; }
  }
    
}