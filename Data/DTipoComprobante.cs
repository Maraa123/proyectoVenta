using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;


namespace Data
{
    public class DTipoComprobante
    {

        public static TipoComprobante GetById(int idTipo)
        {
            TipoComprobante result = new TipoComprobante();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDTipo", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idTipo", idTipo);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new TipoComprobante
                        (Convert.ToInt32(reader["idTipo"]), 
                        reader["descripcion"].ToString(),
                        reader["codigoAFIP"].ToString());


    }

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }




    }
}
