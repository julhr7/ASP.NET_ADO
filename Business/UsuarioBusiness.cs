using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
using Data.Repositorio;
using Entity;
using Entity.Entidades;

namespace Business
{
    public class UsuarioBusiness: IUsuarioBusiness
    {
        private readonly IUsuarioRepositorio usuarioDL;

        public UsuarioBusiness(IUsuarioRepositorio data)
        {
            this.usuarioDL = data;
        }


        public async Task<List<Usuario>> ObtenerUsuario()
        {
            try
            {
                return await usuarioDL.ObtenerUsuario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> ObtenerUsuarioById(int id)
        {
            try
            {
                return await usuarioDL.ObtenerUsuarioById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
