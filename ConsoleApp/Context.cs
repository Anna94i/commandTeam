using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Context : DbContext
    {

        public Context() : base("DataContext")
        {

        }

        public DbSet<MusicRecords> Records { get; set; }
        public DbSet<OnlineStore> OnlineStores { get; set; }
        
    }
}
