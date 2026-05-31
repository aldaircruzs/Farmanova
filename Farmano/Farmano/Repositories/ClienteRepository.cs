using Farmano.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Farmano.Repositories
{
    public class ClienteRepository
    {
        ConexionBD conexion =
            new ConexionBD();

        public bool Guardar(Cliente c)
        {
            bool guardado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"INSERT INTO cliente
                (
                    numero_cliente,
                    nombre,
                    apellido,
                    correo_electronico,
                    telefono
                )
                VALUES
                (
                    @numero,
                    @nombre,
                    @apellido,
                    @correo,
                    @telefono
                )";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@numero", c.NumeroCliente);
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@apellido", c.Apellido);
                cmd.Parameters.AddWithValue("@correo", c.CorreoElectronico);
                cmd.Parameters.AddWithValue("@telefono", c.Telefono);

                guardado = cmd.ExecuteNonQuery() > 0;
            }

            return guardado;
        }

        public bool Eliminar(int idCliente)
        {
            bool eliminado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"DELETE FROM cliente
          WHERE id_cliente = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    idCliente);

                eliminado =
                    cmd.ExecuteNonQuery() > 0;
            }

            return eliminado;
        }

        public List<Cliente> Listar()
        {
            List<Cliente> lista =
                new List<Cliente>();

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"SELECT *
          FROM cliente
          ORDER BY id_cliente";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                NpgsqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Cliente
                    {
                        IdCliente =
                            Convert.ToInt32(dr["id_cliente"]),

                        NumeroCliente =
                            Convert.ToInt32(dr["numero_cliente"]),

                        Nombre =
                            dr["nombre"].ToString(),

                        Apellido =
                            dr["apellido"].ToString(),

                        CorreoElectronico =
                            dr["correo_electronico"].ToString(),

                        Telefono =
                            dr["telefono"].ToString()
                    });
                }
            }

            return lista;
        }
    }
}
