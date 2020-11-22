using Capa_Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class da_proveedor
    {
        public bool proveedor_ins(Proveedor obPro)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "proveedor_ins", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            
            try
            {
                cmd.Parameters.Add("@empresa", SqlDbType.VarChar, 100).Value = obPro.Empresa;
                cmd.Parameters.Add("@tiporeg", SqlDbType.VarChar, 80).Value = obPro.Tipreg;
                cmd.Parameters.Add("@nreg", SqlDbType.Int).Value = obPro.Nreg;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar, 80).Value = obPro.Correo;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 80).Value = obPro.Direccion;
                cmd.Parameters.Add("@tipoprod", SqlDbType.VarChar, 80).Value = obPro.Tipoprod;
                resp = true;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
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
            return resp;
        }
        public ColeccionClases proveedor_sel()
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "proveedor_sel", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Connection.Open();
            try
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Proveedor obPro = new Proveedor();
                        if (!dr[0].Equals(DBNull.Value))
                            obPro.Idempresa = dr.GetInt32(0);
                        if (!dr[1].Equals(DBNull.Value))
                            obPro.Empresa = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            obPro.Tipreg = dr.GetString(2);
                        if (!dr[3].Equals(DBNull.Value))
                            obPro.Nreg = dr.GetInt32(3);
                        if (!dr[4].Equals(DBNull.Value))
                            obPro.Correo = dr.GetString(4);
                        if (!dr[5].Equals(DBNull.Value))
                            obPro.Direccion = dr.GetString(5);
                        if (!dr[6].Equals(DBNull.Value))
                            obPro.Tipoprod = dr.GetString(6);
                        obCol.Add(obPro);
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
        public ColeccionClases proveedor_sel_especial(string texto)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "proveedor_sel_especial", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Parameters.Add("@texto", SqlDbType.VarChar, 100).Value = texto;
            cmd.Connection.Open();
            try
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Proveedor obPro = new Proveedor();
                        if (!dr[0].Equals(DBNull.Value))
                            obPro.Idempresa = dr.GetInt32(0);
                        if (!dr[1].Equals(DBNull.Value))
                            obPro.Empresa = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            obPro.Tipreg = dr.GetString(2);
                        if (!dr[3].Equals(DBNull.Value))
                            obPro.Nreg = dr.GetInt32(3);
                        if (!dr[4].Equals(DBNull.Value))
                            obPro.Correo = dr.GetString(4);
                        if (!dr[5].Equals(DBNull.Value))
                            obPro.Direccion = dr.GetString(5);
                        if (!dr[6].Equals(DBNull.Value))
                            obPro.Tipoprod = dr.GetString(6);
                        obCol.Add(obPro);
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
        string tipo;
        public string proveedor_sel_by_id(int idtra)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            SqlCommand cmd = new SqlCommand() { CommandText = "proveedor_sel_by_id", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Parameters.Add("@idtra", SqlDbType.VarChar, 100).Value = idtra;
            cmd.Connection.Open();
            try
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {                     
                        if (!dr[0].Equals(DBNull.Value))
                           tipo = dr.GetString(0);                      
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
            return tipo;
        }
    }
}
