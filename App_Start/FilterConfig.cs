using System.Web;
using System.Web.Mvc;

namespace CadastroUsuario_teste_psm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
