using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class da_insumos
    {
        public bool insumos_ins(Insumos obInsu)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "insumos_ins", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            try
            {
                cmd.Parameters.Add("@fecha_reg", SqlDbType.Date).Value = obInsu.Fecha_reg;
                cmd.Parameters.Add("@insumo", SqlDbType.VarChar, 50).Value = obInsu.Insumo;
                cmd.Parameters.Add("@tipo_cant", SqlDbType.VarChar, 30).Value = obInsu.Tipo_cant;
                cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = obInsu.Cantidad;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = obInsu.Descripcion;
                cmd.Parameters.Add("@idempresa", SqlDbType.Int).Value = obInsu.Idempresa;
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
        public ColeccionClases insumos_sel()
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "insumos_sel", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Connection.Open();
            try
            {
                using(IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Insumos obIns = new Insumos();
                        if (!dr[0].Equals(DBNull.Value))
                            obIns.IdInsumo = dr.GetInt32(0);
                        if (!dr[0].Equals(DBNull.Value))
                            obIns.Fecha_reg = dr.GetDateTime(1);
                        if (!dr[1].Equals(DBNull.Value))
                            obIns.Insumo = dr.GetString(2);
                        if (!dr[2].Equals(DBNull.Value))
                            obIns.Cantidad = dr.GetInt32(3);
                        obCol.Add(obIns);
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
        public ColeccionClases insumos_by_id(int idInsu)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "insumo_by_id", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };

            cmd.Parameters.Add("@idinsu", SqlDbType.Int).Value = idInsu;
            cmd.Connection.Open();
            try
            {
                using(IDataReader dr= cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Insumos obInsu = new Insumos();
                        if (!dr[0].Equals(DBNull.Value))
                            obInsu.Fecha_reg = dr.GetDateTime(0);
                        if (!dr[1].Equals(DBNull.Value))
                            obInsu.Insumo = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            obInsu.Tipo_cant = dr.GetString(2);
                        if (!dr[3].Equals(DBNull.Value))
                            obInsu.Cantidad = dr.GetInt32(3);
                        if (!dr[4].Equals(DBNull.Value))
                            obInsu.Descripcion = dr.GetString(4);
                        if (!dr[5].Equals(DBNull.Value))
                            obInsu.Empresa = dr.GetString(5);
                        obCol.Add(obInsu);
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
        public bool insumo_del(int idInsu)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "insumo_del", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };

            try
            {
                cmd.Parameters.Add("@idinsu", SqlDbType.Int).Value = idInsu;
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
        public bool insumo_upd(Insumos obIns)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "insumos_udp", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            try
            {
                cmd.Parameters.Add("@idinsu", SqlDbType.Int).Value = obIns.IdInsumo;
                cmd.Parameters.Add("@fecha_reg", SqlDbType.Date).Value = obIns.Fecha_reg;
                cmd.Parameters.Add("@insumo", SqlDbType.VarChar, 100).Value = obIns.Insumo;
                cmd.Parameters.Add("@tipo_cant", SqlDbType.VarChar, 30).Value = obIns.Tipo_cant;
                cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = obIns.Cantidad;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = obIns.Descripcion;
                cmd.Parameters.Add("@id_empresa", SqlDbType.Int).Value = obIns.Idempresa;
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
