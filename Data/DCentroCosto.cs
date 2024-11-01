using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelos;

namespace Data
{
    public class DCentroCosto
    {
        public static CentroCosto GetById(int idCentro)
        {
            CentroCosto result = new CentroCosto();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDCentro", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idCentro", idCentro);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new CentroCosto (
                        Convert.ToInt32(reader["idCentro"]),
                        reader["descripcion"].ToString(),
                        Convert.ToInt32(reader["provincia"]));
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
