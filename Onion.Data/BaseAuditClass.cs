using System;

namespace Onion.Data
{
    public abstract class BaseAuditClass
    {
        public int id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}