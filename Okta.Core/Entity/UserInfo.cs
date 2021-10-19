using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okta.Core.Entity
{
    public class UserInfo
    {
        public string id { get; set; }
        public string status { get; set; }
        public DateTime created { get; set; }
        public object activated { get; set; }
        public object statusChanged { get; set; }
        public object lastLogin { get; set; }
        public DateTime lastUpdated { get; set; }
        public object passwordChanged { get; set; }
        public Type type { get; set; }
        public Profile profile { get; set; }
        public Credentials credentials { get; set; }
        public Links _links { get; set; }
    }
}
