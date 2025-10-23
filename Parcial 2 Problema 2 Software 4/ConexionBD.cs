using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Data.Sql;

namespace Parcial_2_Problema_2_Software_4
{
    internal class ConexionBD: IDisposable
    {
        private string servidor;
        private string baseDatos;
        private string usuario;
        private string contra;
        private string puerto;
        private SqlConnection miConexion;

        public SqlConnection getMiConexion()
        {
            return miConexion;
        }

        public void conectar()
        {
            string conexion = @"Data Source=DESKTOP-KHGL6AT\MSSQLSERVER_2022;Initial Catalog=Software_4_Parcial_2_Problema2;Integrated Security=True;Encrypt=False";
            miConexion = new SqlConnection(conexion);
            miConexion.Open();
        }

        public void Dispose()
        {
            cerrarConexion();
        }

        public void cerrarConexion()
        {
            if (miConexion != null && miConexion.State != ConnectionState.Closed)
            {
                miConexion.Close();
            }
        }
    }
}
