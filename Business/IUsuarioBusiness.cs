using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IUsuarioBusiness
    {
        Task<List<Usuario>> ObtenerUsuario();
        Task<Usuario> ObtenerUsuarioById(int id);
    }
}
