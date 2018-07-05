using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tienda.Clases
{
    class Coneccionsql
    {
        MySqlConnection conex;
        string cadena;

        public MySqlConnection conexion()
        {
            cadena = "server=localhost; Database=Proyecto24; uid=root; pdw=";
            conex = new MySqlConnection(cadena);
            return conex;

        }

        protected void Abrirconexion()
        {
            conex.Open();
        }

        protected void Cerrarconexion()
        {
            conex.Close();
        }









    }
}
