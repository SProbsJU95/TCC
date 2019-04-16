using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasTCC.DB.Base;

namespace TelasTCC.DB.Login
{
    class LoginDatabase
    {
        //SELECT usuario_usu, senha_usu FROM `tb_usuario` WHERE usuario_usu = '@usuario_usu' ";
        public List<LoginDTO> Pesquisar()
        {
            LoginDTO dt = new LoginDTO();

            string user = " ' " + dt.Usuario + " ' ";

            string script = "usuario_usu, senha_usu FROM `tb_usuario` WHERE usuario_usu = " + user;

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<LoginDTO> lista = new List<LoginDTO>();

            while (reader.Read())
            {
                LoginDTO dto = new LoginDTO();
                dto.Id = reader.GetInt32("id_usu");
                dto.Usuario = reader.GetString("usuario_usu");
                dto.Senha = reader.GetString("senha_usu");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
