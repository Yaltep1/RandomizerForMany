using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerService
{
    class Connection: DbContext
        {
            public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }

        public Connection() : base(nameOrConnectionString: "Name = Connection")
        {
            Configuration.AutoDetectChangesEnabled = true;
            Database.SetInitializer<Connection>(new Initializer());
        }
    }
}
