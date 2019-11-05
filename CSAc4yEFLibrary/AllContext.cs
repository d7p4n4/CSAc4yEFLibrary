using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CSAc4y.Class;

namespace DataAccess
{
    public class AllContext : DbContext
    {
        public AllContext() : base("Ac4yDb")
        {
            
        }

        public DbSet<Ac4y> Ac4ys { get; set; }
        public DbSet<Ac4yPersistent> Ac4yPersistents { get; set; }
        public DbSet<Ac4yObject> Ac4yObjects { get; set; }
        public DbSet<Ac4yIdentificationBase> Ac4yIdentificationBases { get; set; }
        public DbSet<Ac4yIdentification> Ac4yIdentifications { get; set; }



    }
}
