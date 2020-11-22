using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class da_productos
    {
        public ColeccionClases productos_sel()
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "productos_sel", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Connection.Open();
            try
            {
                using(IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Productos p = new Productos();
                        if (!dr[0].Equals(DBNull.Value))
                            p.IdProd = dr.GetInt32(0);
                        if (!dr[1].Equals(DBNull.Value))
                            p.Descripcion = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            p.Precio= dr.GetDecimal(2);
                        obCol.Add(p);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return obCol;
        }
        public bool productos_upd(Productos obPro)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "productos_upd", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            
            try
            {
                cmd.Parameters.Add("@idprod", SqlDbType.Int).Value = obPro.IdProd;
                cmd.Parameters.Add("@descrip", SqlDbType.VarChar, 100).Value = obPro.Descripcion;
                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = obPro.Precio;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                resp = true;
            }
            catch (Exception)
            {
                resp = false;
                throw;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return resp;
        }
    }
}
