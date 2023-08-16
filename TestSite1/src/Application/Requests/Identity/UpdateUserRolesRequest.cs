using System.Collections.Generic;
using TestSite1.Application.Responses.Identity;

namespace TestSite1.Application.Requests.Identity
{
    public class UpdateUserRolesRequest
    {
        public string UserId { get; set; }
        public IList<UserRoleModel> UserRoles { get; set; }
    }
}