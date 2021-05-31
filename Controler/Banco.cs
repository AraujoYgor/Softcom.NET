using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrilhadeDesenvolvimento.NET.Controler
{
    class Banco
    {
        public static string IniciarConexao
        {
            get { return $"Server=(localdb)\\MSSQLLocalDB;AttachDbFileName=E:\\Projetos\\TrilhadeDesenvolvimento.NET\\Controler\\Base_TrilhadeDesenvolvimento.NET.mdf;Integrated Security=true"; }
        } 
    }
}
