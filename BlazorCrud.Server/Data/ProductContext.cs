using BlazorCrud.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.Data
{
    public class ProductContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured)
            {
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlazorCrud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}
