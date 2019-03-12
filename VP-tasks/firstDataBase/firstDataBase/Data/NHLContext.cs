using firstDataBase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace firstDataBase.Data
{
    public class NHLContext : DbContext
    {
        public NHLContext()
            : base("name=NHL")
        {
                
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}