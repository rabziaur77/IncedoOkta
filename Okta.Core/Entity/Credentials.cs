using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okta.Core.Entity
{
    public class Credentials
    {
        public List<Email> emails { get; set; }
        public Provider provider { get; set; }
    }
}
