using Capa_Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class da_trabajador
    {
        public bool trabajador_ins(Trabajador obTra)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "trabajador_ins", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            try
            {
                cmd.Parameters.Add("@nombres", SqlDbType.VarChar, 100).Value = obTra.Nombres;
                cmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 100).Value = obTra.Apellidos;
                cmd.Parameters.Add("@tipodoc", SqlDbType.VarChar, 100).Value = obTra.Tipodoc;
                cmd.Parameters.Add("@edad", SqlDbType.Int).Value = obTra.Edad;
                cmd.Parameters.Add("@nidentidad", SqlDbType.Int).Value = obTra.Nidentidad;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar,100).Value = obTra.Correo;
                cmd.Parameters.Add("@puesto", SqlDbType.VarChar,100).Value = obTra.Puesto;
                cmd.Parameters.Add("@modalidad", SqlDbType.VarChar,100).Value = obTra.Modalidad;
                cmd.Parameters.Add("@rutaimage", SqlDbType.VarChar, 50).Value = obTra.Rutaimage;
                resp = true;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                
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
        public ColeccionClases trabajador_sel()
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "trabajador_sel", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Connection.Open();

            try
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Trabajador obTra = new Trabajador();
                        if (!dr[0].Equals(DBNull.Value))
                            obTra.IdTrab = dr.GetInt32(0);
                        if (!dr[1].Equals(DBNull.Value))
                            obTra.Nombres = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            obTra.Apellidos = dr.GetString(2);
                        if (!dr[3].Equals(DBNull.Value))
                            obTra.Nidentidad = dr.GetInt32(3);
                        if (!dr[4].Equals(DBNull.Value))
                            obTra.Rutaimage = dr.GetString(4);
                        if (!dr[5].Equals(DBNull.Value))
                            obTra.Correo = dr.GetString(5);
                        if (!dr[6].Equals(DBNull.Value))
                            obTra.Puesto = dr.GetString(6);

                        obCol.Add(obTra);
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
        public ColeccionClases filtrado_trabajador(string texto)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "filtrado_trab", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Parameters.Add("@texto", SqlDbType.VarChar, 100).Value = texto;
            cmd.Connection.Open();

            try
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Trabajador obTra = new Trabajador();
                        if (!dr[0].Equals(DBNull.Value))
                            obTra.IdTrab = dr.GetInt32(0);
                        if (!dr[1].Equals(DBNull.Value))
                            obTra.Nombres = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            obTra.Apellidos = dr.GetString(2);
                        if (!dr[3].Equals(DBNull.Value))
                            obTra.Nidentidad = dr.GetInt32(3);
                        if (!dr[4].Equals(DBNull.Value))
                            obTra.Rutaimage = dr.GetString(4);

                        obCol.Add(obTra);

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
        public bool trabajador_del(int idTra)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "trabajador_del", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            try
            {
                cmd.Parameters.Add("@idtra", SqlDbType.Int).Value = idTra;
                resp = true;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
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
        public ColeccionClases trabajador_sel_by_idtra(int idTra)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "trabajador_sel_by_id", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Parameters.Add("@idtra", SqlDbType.Int).Value = idTra;
            cmd.Connection.Open();
            try
            {
                using(IDataReader dr= cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Trabajador obTra = new Trabajador();
                        if (!dr[0].Equals(DBNull.Value))
                            obTra.Nombres = dr.GetString(0);
                        if (!dr[1].Equals(DBNull.Value))
                            obTra.Apellidos = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            obTra.Correo = dr.GetString(2);
                        if (!dr[3].Equals(DBNull.Value))
                            obTra.Puesto= dr.GetString(3);
                        if (!dr[4].Equals(DBNull.Value))
                            obTra.Modalidad = dr.GetString(4);
                        if (!dr[5].Equals(DBNull.Value))
                            obTra.Tipodoc = dr.GetString(5);
                        if (!dr[6].Equals(DBNull.Value))
                            obTra.Nidentidad = dr.GetInt32(6);
                        if (!dr[7].Equals(DBNull.Value))
                            obTra.Edad = dr.GetInt32(7);
                        if (!dr[8].Equals(DBNull.Value))
                            obTra.Rutaimage= dr.GetString(8);
                        obCol.Add(obTra);
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
        public ColeccionClases prueba()
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "prueba", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Connection.Open();

            try
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Trabajador obTra = new Trabajador();
                        if (!dr[0].Equals(DBNull.Value))
                            obTra.Nombres = dr.GetString(0);
                        if (!dr[1].Equals(DBNull.Value))
                            obTra.Apellidos = dr.GetString(1);                      
                        obCol.Add(obTra);
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
        public ColeccionClases trabajador_Get()
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "trab_get", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Connection.Open();

            try
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Trabajador obTra = new Trabajador();
                        if (!dr[0].Equals(DBNull.Value))
                            obTra.Nidentidad = dr.GetInt32(0);
                        if (!dr[1].Equals(DBNull.Value))
                            obTra.Nombres = dr.GetString(1);
                        obCol.Add(obTra);
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
