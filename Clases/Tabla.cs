using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Tienda.Clases
{
    class Tabla:Coneccionsql
    {
        string instruc;

        public DataTable vertabla()
        {
            instruc = " select * from Producto";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruc, conexion());
            DataTable Consulta = new DataTable();
            adp.Fill(Consulta);
            return Consulta;  
        }















    }
}
