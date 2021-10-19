using Okta.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okta.Core.IRepository
{
    public interface IOktakUserRepository
    {
        Task<UserInfoList> UserList(string url);
        Task<UserInfoWithStatus> UserInfo(string url);
    }
}
