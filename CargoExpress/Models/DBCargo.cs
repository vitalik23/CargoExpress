using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoExpress.Models
{
    public class DBCargo : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DBCargo(DbContextOptions<DBCargo> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
