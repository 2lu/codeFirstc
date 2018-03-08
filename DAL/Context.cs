using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using CadastroUsuario_teste_psm.Models;

namespace CadastroUsuario_teste_psm.DAL
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Sexo> Sexo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

   
}
