using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class da_ventas
    {
        public bool ventas_ins(Venta v)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "Ventas_ins", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            try
            {
                cmd.Parameters.Add("@cliente", SqlDbType.VarChar, 100).Value = v.Cliente;
                cmd.Parameters.Add("@met_pago", SqlDbType.VarChar, 50).Value = v.Met_pago;
                cmd.Parameters.Add("@id_vend", SqlDbType.Int).Value = v.Id_vend;
                cmd.Parameters.Add("@vale", SqlDbType.VarChar, 50).Value = v.Vale;
                cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = v.Total;
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
        public ColeccionClases ventas_sel()
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "ventas_sel", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            cmd.Connection.Open();
            try
            {
                using(IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Venta v = new Venta();
                        if (!dr[0].Equals(DBNull.Value))
                            v.Id_venta = dr.GetString(0);
                        if (!dr[1].Equals(DBNull.Value))
                            v.Cliente = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            v.Fecha_emision = dr.GetDateTime(2);
                        if (!dr[3].Equals(DBNull.Value))
                            v.Met_pago = dr.GetString(3);
                        if (!dr[4].Equals(DBNull.Value))
                            v.Total = dr.GetDecimal(4);
                        obCol.Add(v);
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
        public ColeccionClases sel_by_ideventa(string id_venta)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "sel_by_ideventa", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };

            cmd.Parameters.Add("@id_venta", SqlDbType.VarChar).Value = id_venta;
            cmd.Connection.Open();
            try
            {
                using(IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Venta v = new Venta();
                        if (!dr[0].Equals(DBNull.Value))
                            v.Id_venta = dr.GetString(0);
                        if (!dr[1].Equals(DBNull.Value))
                            v.Cliente = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            v.Fecha_emision = dr.GetDateTime(2);
                        if (!dr[3].Equals(DBNull.Value))
                            v.Vendedor = dr.GetString(3);
                        if (!dr[4].Equals(DBNull.Value))
                            v.Met_pago = dr.GetString(4);
                        if (!dr[5].Equals(DBNull.Value))
                            v.Total = dr.GetDecimal(5);
                        if (!dr[6].Equals(DBNull.Value))
                            v.Vale = dr.GetString(6);
                        if (!dr[7].Equals(DBNull.Value))
                            v.Estado = dr.GetString(7);
                            obCol.Add(v);
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
        public bool pagar_pedido(string id_venta)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "pagar_pedido", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            try
            {
                cmd.Parameters.Add("@id_venta", SqlDbType.VarChar, 50).Value = id_venta;
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
        public ColeccionClases vent_sel_unica(DateTime fecha_ini)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "vent_sel_unica", CommandType = System.Data.CommandType.StoredProcedure,Connection=cn };
            cmd.Parameters.Add("@fecha_ini", SqlDbType.Date).Value = fecha_ini;
            cmd.Connection.Open();
            try
            {
                using(IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Venta v = new Venta();
                        if (!dr[0].Equals(DBNull.Value))
                            v.Id_venta = dr.GetString(0);
                        if (!dr[1].Equals(DBNull.Value))
                            v.Cliente = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            v.Met_pago = dr.GetString(2);
                        if (!dr[3].Equals(DBNull.Value))
                            v.Vendedor = dr.GetString(3);
                        if (!dr[4].Equals(DBNull.Value))
                            v.Vale = dr.GetString(4);
                        if (!dr[5].Equals(DBNull.Value))
                            v.Total = dr.GetDecimal(5);
                        if (!dr[6].Equals(DBNull.Value))
                            v.Fecha_emision = dr.GetDateTime(6);
                        if (!dr[7].Equals(DBNull.Value))
                            v.Estado = dr.GetString(7);
                        obCol.Add(v);
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

        public ColeccionClases vent_sel_intervalo(DateTime fecha_ini,DateTime fecha_fin)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            ColeccionClases obCol = new ColeccionClases();
            SqlCommand cmd = new SqlCommand() { CommandText = "vent_sel_intervalo", CommandType = System.Data.CommandType.StoredProcedure };
            cmd.Parameters.Add("@fecha_ini", SqlDbType.Date).Value = fecha_ini;
            cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fecha_fin;
            cmd.Connection.Open();
            try
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Venta v = new Venta();
                        if (!dr[0].Equals(DBNull.Value))
                            v.Id_venta = dr.GetString(0);
                        if (!dr[1].Equals(DBNull.Value))
                            v.Cliente = dr.GetString(1);
                        if (!dr[2].Equals(DBNull.Value))
                            v.Met_pago = dr.GetString(2);
                        if (!dr[3].Equals(DBNull.Value))
                            v.Vendedor = dr.GetString(3);
                        if (!dr[4].Equals(DBNull.Value))
                            v.Vale = dr.GetString(4);
                        if (!dr[5].Equals(DBNull.Value))
                            v.Total = dr.GetDecimal(5);
                        if (!dr[6].Equals(DBNull.Value))
                            v.Fecha_emision = dr.GetDateTime(6);
                        if (!dr[7].Equals(DBNull.Value))
                            v.Estado = dr.GetString(7);
                        obCol.Add(v);
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
        public bool ventas_del(string id_venta)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand() { CommandText = "ventas_del", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            try
            {
                cmd.Parameters.Add("@id_venta", SqlDbType.VarChar, 50).Value = id_venta;
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
        public bool ventas_udp(Venta v)
        {
            SqlConnection cn = new SqlConnection(new Conexion().cadenaConexion());
            bool resp = false;
            SqlCommand cmd = new SqlCommand { CommandText = "ventas_udp", CommandType = System.Data.CommandType.StoredProcedure, Connection = cn };
            try
            {
                cmd.Parameters.Add("@id_venta", SqlDbType.VarChar, 50).Value = v.Id_venta;
                cmd.Parameters.Add("@cliente", SqlDbType.VarChar, 50).Value = v.Cliente;
                cmd.Parameters.Add("@met_pago", SqlDbType.VarChar, 50).Value = v.Met_pago;
                cmd.Parameters.Add("@vale", SqlDbType.VarChar, 50).Value = v.Vale;
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = v.Fecha_emision;

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
