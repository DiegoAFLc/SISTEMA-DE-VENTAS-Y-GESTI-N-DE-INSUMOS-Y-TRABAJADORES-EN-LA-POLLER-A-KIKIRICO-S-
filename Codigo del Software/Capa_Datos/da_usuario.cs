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
    public class da_usuario
    {
        string ident;
        string tipoUs;
        string nombreCompl;
        public bool validar_usuario(string usuario,string contraseña)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            SqlCommand cmd = new SqlCommand() { CommandText = "validar_usuario", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100).Value = usuario;
            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 100).Value = contraseña;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();

            try
            {
               using(IDataReader dr= cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                       ident = dr.GetString(0);
                    }
                }               
            }
            catch (Exception)
            {               
                throw;
            }
            finally
            {
                cmd.Dispose();
                cmd.Connection.Close();
            }
            if (ident is null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public ColeccionClases usuario_sel()
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "usario_sel", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Connection.Open();

            using (IDataReader dr = cmd.ExecuteReader())
            {
                Usuario obUs = new Usuario();
                while (dr.Read())
                {
                    if (!dr[0].Equals(DBNull.Value))
                        obUs.IdUsuario = dr.GetInt32(0);
                    if (!dr[1].Equals(DBNull.Value))
                        obUs.Usuarios = dr.GetString(1);
                    if (!dr[2].Equals(DBNull.Value))
                        obUs.IdTipo = dr.GetInt32(2);
                    obCol.Add(obUs);
                }
            }
            return obCol;
        }
        public string val_tipo_us(string us,string contra)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            SqlCommand cmd = new SqlCommand() { CommandText = "val_tipo_us", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100).Value = us;
            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 100).Value = contra;
            cmd.Connection.Open();

            using (IDataReader dr = cmd.ExecuteReader())
            {
                Usuario obUs = new Usuario();
                while (dr.Read())
                {
                    if (!dr[0].Equals(DBNull.Value))
                        tipoUs = dr.GetString(0);                 
                }
            }
            return tipoUs;
        }
        public string nombre_usuarios(string us,string contraseña)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            SqlCommand cmd = new SqlCommand() { CommandText = "nombre_usuarios", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100).Value = us;
            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 100).Value = contraseña;
            cmd.Connection.Open();
            using(IDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (!dr[0].Equals(DBNull.Value))
                        nombreCompl = dr.GetString(0);
                    if (!dr[1].Equals(DBNull.Value))
                        nombreCompl =nombreCompl+" "+dr.GetString(1);
                }
            }
            return nombreCompl;
        }
        public bool usuario_ins(Usuario obUs)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "usuario_ins", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            try
            {
                cmd.Parameters.Add("@nidenti", SqlDbType.VarChar).Value = obUs.Nidenti;
                cmd.Parameters.Add("@idtipo", SqlDbType.Int).Value = obUs.IdTipo;
                cmd.Parameters.Add("@usu", SqlDbType.VarChar, 100).Value = obUs.Usuarios;
                cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 100).Value = obUs.Contraseña;
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
