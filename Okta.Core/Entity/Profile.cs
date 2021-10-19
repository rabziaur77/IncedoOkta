using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okta.Core.Entity
{
    public class Profile
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public object mobilePhone { get; set; }
        public object secondEmail { get; set; }
        public string login { get; set; }
        public string email { get; set; }
    }
}
