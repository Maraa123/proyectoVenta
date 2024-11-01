using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data
{
    public class DVenta
    {
        public static List<Venta> GetAll()
        {
            List<Venta> result = new List<Venta>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllInscripciones", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = DCliente.GetById(Convert.ToInt32(reader["idCliente"]));
                    TipoComprobante tipoComprobante = DTipoComprobante.GetById(Convert.ToInt32(reader["idTipoComprobante"]));
                    Moneda moneda = DMoneda.GetById(Convert.ToInt32(reader["idMoneda"]));
                    CentroCosto centroCosto = DCentroCosto.GetById(Convert.ToInt32(reader["idCentroCosto"]));

                    var venta = new Venta(
                        Convert.ToInt32(reader["idVenta"]),
                        cliente,
                        tipoComprobante,
                        moneda,
                        (DateTime)(reader["fecha"]),
                        Convert.ToInt32(reader["imputacion"]),
                        Convert.ToDecimal(reader["tipoCambio"]),
                        Convert.ToInt32(reader["punto"]),
                        reader["numero"].ToString(),
                        Convert.ToDouble(reader["netoGravado"]),
                        Convert.ToDouble(reader["netoNoGravado"]),
                        Convert.ToDouble(reader["exento"]),
                        Convert.ToDouble(reader["iva"]),
                        Convert.ToDouble(reader["perIVA"]),
                        Convert.ToDouble(reader["percIIBB"]),
                        Convert.ToDouble(reader["percMunicipalidad"]),
                        centroCosto
                         );

                    result.Add(venta);
                }

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }


        public static void InsertVenta(int codCliente, int codTipoComprobante, int codMoneda, DateTime fecha, int imputacion, decimal tipoCambio, int punto, string numero, double netoGravado, double netoNoGravado, double exento, double iva, double percIVA, double percIIBB, double percMunicipalidad, int codCentroCosto
)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("InsertVenta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@codCliente", codCliente);
                command.Parameters.AddWithValue("@codTipoComprobante", codTipoComprobante);
                command.Parameters.AddWithValue("@codMoneda", codMoneda);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@imputacion", imputacion);
                command.Parameters.AddWithValue("@tipoCambio", tipoCambio);
                command.Parameters.AddWithValue("@punto", punto);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@netoGravado", netoGravado);
                command.Parameters.AddWithValue("@netoNoGravado", netoNoGravado);
                command.Parameters.AddWithValue("@exento", exento);
                command.Parameters.AddWithValue("@iva", iva);
                command.Parameters.AddWithValue("@percIVA", percIVA);
                command.Parameters.AddWithValue("@percIIBB", percIIBB);
                command.Parameters.AddWithValue("@percMunicipalidad", percMunicipalidad);
                command.Parameters.AddWithValue("@codCentroCosto", codCentroCosto);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void UpdateVenta(int codCliente, int codTipoComprobante, int codMoneda, DateTime fecha, int imputacion, decimal tipoCambio, int punto, string numero, double netoGravado, double netoNoGravado, double exento, double iva, double percIVA, double percIIBB, double percMunicipalidad, int codCentroCosto
)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("UpdateVenta", connection);
                command.Parameters.AddWithValue("@codCliente", codCliente);
                command.Parameters.AddWithValue("@codTipoComprobante", codTipoComprobante);
                command.Parameters.AddWithValue("@codMoneda", codMoneda);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@imputacion", imputacion);
                command.Parameters.AddWithValue("@tipoCambio", tipoCambio);
                command.Parameters.AddWithValue("@punto", punto);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@netoGravado", netoGravado);
                command.Parameters.AddWithValue("@netoNoGravado", netoNoGravado);
                command.Parameters.AddWithValue("@exento", exento);
                command.Parameters.AddWithValue("@iva", iva);
                command.Parameters.AddWithValue("@percIVA", percIVA);
                command.Parameters.AddWithValue("@percIIBB", percIIBB);
                command.Parameters.AddWithValue("@percMunicipalidad", percMunicipalidad);
                command.Parameters.AddWithValue("@codCentroCosto", codCentroCosto);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static void DeleteVenta(int idVenta)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("deleteVenta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idVenta", idVenta);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Insert(object text1, string text2)
        {
            throw new NotImplementedException();
        }
    }
}

