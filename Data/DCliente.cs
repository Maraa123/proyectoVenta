using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;


namespace Data
{
        public class DCliente
    {
        public static Cliente GetById(int idCliente)
        {
            Cliente result = new Cliente();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDCliente", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idCliente", idCliente);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new Cliente(
                        Convert.ToInt32(reader["idCliente"]),
                        reader["cuit"].ToString(),
                        reader["nombre"].ToString(),
                        Convert.ToInt32(reader["iva"])
                        );
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
