using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onion.Data
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<BookEntity> entityBuilder)
        {
            entityBuilder.HasKey(k => k.id);
        }
    }
}
