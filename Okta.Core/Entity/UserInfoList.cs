using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okta.Core.Entity
{
    public class UserInfoList
    {
        public List<UserInfo> UserList { get; set; }
        public string Status { get; set; }
    }
}
