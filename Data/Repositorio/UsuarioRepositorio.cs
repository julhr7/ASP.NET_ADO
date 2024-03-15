using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.Configuracion;
using Entity.Entidades;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ConfiguracionConexion _conexion;

        public UsuarioRepositorio(IOptions<ConfiguracionConexion> conexion)
        {
            _conexion = conexion.Value;
        }

        public async Task<List<Usuario>> ObtenerUsuario()
        {
            List<Usuario> ListUsuarios = new List<Usuario>();

            using (var conexion = new SqlConnection(_conexion.CadenaSQL))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_usuario_sel", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while(await dr.ReadAsync())
                    {
                        ListUsuarios.Add(new Usuario()
                        {
                            IdUsuario = Convert.ToInt32(dr["idUsuario"]),
                            Nombres = dr["nombres"].ToString(),
                            Apellidos = dr["apellidos"].ToString(),
                            Edad = Convert.ToInt32(dr["edad"])
                        });
                    }
                }
            }
            return ListUsuarios;
        }

        public async Task<Usuario> ObtenerUsuarioById(int id)
        {
            Usuario Usuario = new Usuario();

            using (var conexion = new SqlConnection(_conexion.CadenaSQL))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_usuarioById", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idUsuario", id));
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        Usuario.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
                        Usuario.Nombres = dr["nombres"].ToString();
                        Usuario.Apellidos = dr["apellidos"].ToString();
                        Usuario.Edad = Convert.ToInt32(dr["edad"]);
                    }
                }
            }
            return Usuario;
        }
    }
}
