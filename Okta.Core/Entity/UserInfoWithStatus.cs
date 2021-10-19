using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okta.Core.Entity
{
    public class UserInfoWithStatus
    {
        public UserInfo UserData { get; set; }
        public string Status { get; set; }
    }
}
