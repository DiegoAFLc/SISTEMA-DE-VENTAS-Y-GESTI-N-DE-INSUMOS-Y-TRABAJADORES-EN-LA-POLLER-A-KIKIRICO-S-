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
    public class da_tipo_usuario
    {
        public ColeccionClases tipo_usuario()
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "tipo_usuario_sel", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Connection.Open();

            try
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tipo_usuario obTip = new tipo_usuario();
                        if (!dr[0].Equals(DBNull.Value))
                            obTip.IdTipo = dr.GetInt32(0);
                        if (!dr[1].Equals(DBNull.Value))
                            obTip.Descripcion = dr.GetString(1);
                        obCol.Add(obTip);
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
    }
}
