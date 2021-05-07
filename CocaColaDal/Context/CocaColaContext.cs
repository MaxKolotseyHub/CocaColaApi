using CocaColaDal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocaColaDal.Context
{
    public class CocaColaContext: DbContext
    {
        public DbSet<Code> Codes{ get; set; }
        public DbSet<User> Users{ get; set; }

        public CocaColaContext(string connectionString ="Default"): base(connectionString)
        {
            Database.SetInitializer<CocaColaContext>(new CocaColaInitializer());
        }
    }
}
