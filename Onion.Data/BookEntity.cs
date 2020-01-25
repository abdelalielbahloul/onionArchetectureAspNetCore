using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onion.Data
{
    public class BookEntity : BaseAuditClass
    {
        public int ordinal { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
