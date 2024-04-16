using Bookstore.Models.DomainModels;
using Microsoft.AspNetCore.Identity;

namespace Bookstore.Models.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; } = null!;
        public IEnumerable<IdentityRole> Roles { get; set; } = null!;
    }
}
