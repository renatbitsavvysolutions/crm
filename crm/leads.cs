using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm
{
    class Leads : Customer
    {

        public string activities { get; set; }
        public string notes { get; set; }
        public string leadSource { get; set; }
        public string leadOwner { get; set; }
        public string leadStatus { get; set; }
        public string annualRevenue { get; set; }

    }
}
