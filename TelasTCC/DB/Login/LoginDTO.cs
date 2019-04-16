using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasTCC.DB.Login
{
    class LoginDTO
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        //PEGAR MAIS IFORMAÇÕES SE FOR COLOCAR ISSO NO BANCO DE DADOS
    }
}
