using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> ObtenerUsuario();
        Task<Usuario> ObtenerUsuarioById(int id);
    }
}
