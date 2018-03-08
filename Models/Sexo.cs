using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroUsuario_teste_psm.Models
{
    public class Sexo
    {
        public int SexoId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }

    }
}
