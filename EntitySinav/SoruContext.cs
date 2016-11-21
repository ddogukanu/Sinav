using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySinav
{
    class SoruContext :DbContext
    {
        public virtual DbSet<Soru> Sorular { get; set; }
    }
}
