using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using e_commerce.Models;
using System.Data.Entity;

namespace e_commerce.Context
{
    public class Context
    {
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Produtor> Produtor { get; set; }
        public DbSet<Ator> Ator { get; set; }
        public DbSet<Ator_Filme>Ator_Filme{get;set;}
        
    }
}