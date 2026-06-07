using Farmano.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Farmano.Repositories
{
    public class ProveedorRepository
    {
        ConexionBD conexion =
            new ConexionBD();

        public bool Guardar(Proveedor p)
        {
            bool guardado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"INSERT INTO proovedor
                (
                    nombre,
                    direccion,
                    numero_telefono,
                    numero_certificacion,
                    cp,
                    rfc
                )
                VALUES
                (
                    @nombre,
                    @direccion,
                    @telefono,
                    @certificacion,
                    @cp,
                    @rfc
                )";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@direccion", p.Direccion);
                cmd.Parameters.AddWithValue("@telefono", p.NumeroTelefono);
                cmd.Parameters.AddWithValue("@certificacion", p.NumeroCertificacion);
                cmd.Parameters.AddWithValue("@cp", p.CP);
                cmd.Parameters.AddWithValue("@rfc", p.RFC);

                guardado =
                    cmd.ExecuteNonQuery() > 0;
            }

            return guardado;
        }

        public List<Proveedor> Listar()
        {
            List<Proveedor> lista =
                new List<Proveedor>();

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"SELECT *
                  FROM proovedor
                  ORDER BY id_proveedor";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                NpgsqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Proveedor
                    {
                        IdProveedor =
                            Convert.ToInt32(dr["id_proveedor"]),

                        Nombre =
                            dr["nombre"].ToString(),

                        Direccion =
                            dr["direccion"].ToString(),

                        NumeroTelefono =
                            dr["numero_telefono"].ToString(),

                        NumeroCertificacion =
                            dr["numero_certificacion"].ToString(),

                        CP =
                            dr["cp"].ToString(),

                        RFC =
                            dr["rfc"].ToString()
                    });
                }
            }

            return lista;
        }

        public List<Proveedor> Buscar(string texto)
        {
            List<Proveedor> lista =
                new List<Proveedor>();

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"SELECT *
                  FROM proveedor
                  WHERE nombre ILIKE @texto
                  OR rfc ILIKE @texto";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@texto",
                    "%" + texto + "%");

                NpgsqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Proveedor
                    {
                        IdProveedor =
                            Convert.ToInt32(dr["id_proveedor"]),

                        Nombre =
                            dr["nombre"].ToString(),

                        Direccion =
                            dr["direccion"].ToString(),

                        NumeroTelefono =
                            dr["numero_telefono"].ToString(),

                        NumeroCertificacion =
                            dr["numero_certificacion"].ToString(),

                        CP =
                            dr["cp"].ToString(),

                        RFC =
                            dr["rfc"].ToString()
                    });
                }
            }

            return lista;
        }

        public bool Actualizar(Proveedor p)
        {
            bool actualizado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"UPDATE proveedor
                  SET nombre=@nombre,
                      direccion=@direccion,
                      numero_telefono=@telefono,
                      numero_certificacion=@certificacion,
                      cp=@cp,
                      rfc=@rfc
                  WHERE id_proveedor=@id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", p.IdProveedor);
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@direccion", p.Direccion);
                cmd.Parameters.AddWithValue("@telefono", p.NumeroTelefono);
                cmd.Parameters.AddWithValue("@certificacion", p.NumeroCertificacion);
                cmd.Parameters.AddWithValue("@cp", p.CP);
                cmd.Parameters.AddWithValue("@rfc", p.RFC);

                actualizado =
                    cmd.ExecuteNonQuery() > 0;
            }

            return actualizado;
        }

        public bool Eliminar(int id)
        {
            bool eliminado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"DELETE FROM proveedor
                  WHERE id_proveedor=@id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", id);

                eliminado =
                    cmd.ExecuteNonQuery() > 0;
            }

            return eliminado;
        }
    }
}