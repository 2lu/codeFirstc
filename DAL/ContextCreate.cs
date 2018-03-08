using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CadastroUsuario_teste_psm.Models;

namespace CadastroUsuario_teste_psm.DAL
{
    public class ContextCreate : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {

            var usuario = new List<Usuario>
            {
                new Usuario { Ativo= true, Email = null, DataNascimento=DateTime.Parse("2005-09-01"), Nome= null, Senha = null },

            };
            usuario.ForEach(s => context.Usuario.Add(s));
            context.SaveChanges();
            var sexo = new List<Sexo>
            {
                new Sexo { Descricao="Masculino" },
                new Sexo { Descricao="Feminino" }
           };
            sexo.ForEach(s => context.Sexo.Add(s));
            context.SaveChanges();

           
        }
    }

}