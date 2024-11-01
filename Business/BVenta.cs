using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Modelos;

namespace Business
{
    internal class BVenta
    {
        public static List<Venta> Get()
        {
            try
            {

                return DVenta.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Insert(int idVenta, int codCliente, int codTipoComprobante, int codMoneda, DateTime fecha, int imputacion, decimal tipoCambio, int punto, string numero, double netoGravado, double netoNoGravado, double exento, double iva, double percIVA, double percIIBB, double percMunicipalidad, int codCentroCosto)
            
        {
            try
            {
                DVenta.InsertVenta( codCliente,  codTipoComprobante,  codMoneda,  fecha,  imputacion,  tipoCambio,  punto,  numero,  netoGravado,  netoNoGravado,exento,  iva, percIVA,  percIIBB,percMunicipalidad, codCentroCosto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(int idVenta, int codCliente, int codTipoComprobante, int codMoneda, DateTime fecha, int imputacion, decimal tipoCambio, int punto, string numero, double netoGravado, double netoNoGravado, double exento, double iva, double percIVA, double percIIBB, double percMunicipalidad, int codCentroCosto)
        {
            try
            {
                DVenta.UpdateVenta(codCliente, codTipoComprobante, codMoneda, fecha, imputacion, tipoCambio, punto, numero, netoGravado, netoNoGravado, exento, iva, percIVA, percIIBB, percMunicipalidad, codCentroCosto);
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
