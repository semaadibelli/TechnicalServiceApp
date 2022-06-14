using Microsoft.AspNetCore.Identity;

namespace TechnicalService.Data.Identity
{
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {       
        }


    }
}
