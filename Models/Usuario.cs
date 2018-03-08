using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroUsuario_teste_psm.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public int SexoId { get; set; }
        public virtual Sexo Sexo { get; set; }

    }
}

