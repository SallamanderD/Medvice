using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Medvice.Models
{
    public class MedviceContext : DbContext
    {
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Simpotom> Simpotoms { get; set; }
    }
}