using Farmano.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Farmano.Repositories
{
    public class MedicamentoRepository
    {
        ConexionBD conexion =
            new ConexionBD();

        public bool Guardar(Medicamento m)
        {
            bool guardado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"INSERT INTO medicamento
                (
                    codigo,
                    nombre,
                    numero_fabricacion,
                    presentacion,
                    stock,
                    precio
                )
                VALUES
                (
                    @codigo,
                    @nombre,
                    @fabricacion,
                    @presentacion,
                    @stock,
                    @precio
                )";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@codigo", m.Codigo);
                cmd.Parameters.AddWithValue("@nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@fabricacion", m.NumeroFabricacion);
                cmd.Parameters.AddWithValue("@presentacion", m.Presentacion);
                cmd.Parameters.AddWithValue("@stock", m.Stock);
                cmd.Parameters.AddWithValue("@precio", m.Precio);

                int filas = cmd.ExecuteNonQuery();

                guardado = filas > 0;
            }

            return guardado;
        }

        public List<Medicamento> Listar()
        {
            List<Medicamento> lista =
                new List<Medicamento>();

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"SELECT *
                  FROM medicamento
                  ORDER BY id_medicamento";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                NpgsqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Medicamento
                    {
                        IdMedicamento =
                            Convert.ToInt32(dr["id_medicamento"]),

                        Codigo =
                            dr["codigo"].ToString(),

                        Nombre =
                            dr["nombre"].ToString(),

                        NumeroFabricacion =
                            dr["numero_fabricacion"].ToString(),

                        Presentacion =
                            dr["presentacion"].ToString(),

                        Stock =
                            Convert.ToInt32(dr["stock"]),

                        Precio =
                            Convert.ToDecimal(dr["precio"])
                    });
                }
            }

            return lista;
        }

        public List<Medicamento> Buscar(string texto)
        {
            List<Medicamento> lista =
                new List<Medicamento>();

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"SELECT *
                  FROM medicamento
                  WHERE codigo ILIKE @texto
                  OR nombre ILIKE @texto";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@texto",
                    "%" + texto + "%");

                NpgsqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Medicamento
                    {
                        IdMedicamento =
                            Convert.ToInt32(dr["id_medicamento"]),

                        Codigo =
                            dr["codigo"].ToString(),

                        Nombre =
                            dr["nombre"].ToString(),

                        NumeroFabricacion =
                            dr["numero_fabricacion"].ToString(),

                        Presentacion =
                            dr["presentacion"].ToString(),

                        Stock =
                            Convert.ToInt32(dr["stock"]),

                        Precio =
                            Convert.ToDecimal(dr["precio"])
                    });
                }
            }

            return lista;
        }

        public bool Actualizar(Medicamento m)
        {
            bool actualizado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"UPDATE medicamento
                  SET codigo=@codigo,
                      nombre=@nombre,
                      numero_fabricacion=@fabricacion,
                      presentacion=@presentacion,
                      stock=@stock,
                      precio=@precio
                  WHERE id_medicamento=@id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", m.IdMedicamento);
                cmd.Parameters.AddWithValue("@codigo", m.Codigo);
                cmd.Parameters.AddWithValue("@nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@fabricacion", m.NumeroFabricacion);
                cmd.Parameters.AddWithValue("@presentacion", m.Presentacion);
                cmd.Parameters.AddWithValue("@stock", m.Stock);
                cmd.Parameters.AddWithValue("@precio", m.Precio);

                int filas = cmd.ExecuteNonQuery();

                actualizado = filas > 0;
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
                @"DELETE FROM medicamento
                  WHERE id_medicamento = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", id);

                int filas = cmd.ExecuteNonQuery();

                eliminado = filas > 0;
            }

            return eliminado;
        }

        public bool EntradaStock(int id, int cantidad)
        {
            bool actualizado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"UPDATE medicamento
                  SET stock = stock + @cantidad
                  WHERE id_medicamento = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@id", id);

                int filas = cmd.ExecuteNonQuery();

                actualizado = filas > 0;
            }

            return actualizado;
        }


        public bool SalidaStock(int id,int cantidad)
        {
            bool actualizado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                @"UPDATE medicamento
          SET stock = stock - @cantidad
          WHERE id_medicamento = @id
          AND stock >= @cantidad";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@cantidad",
                    cantidad);

                cmd.Parameters.AddWithValue(
                    "@id",
                    id);

                int filas =
                    cmd.ExecuteNonQuery();

                actualizado = filas > 0;
            }

            return actualizado;
        }
    }
}