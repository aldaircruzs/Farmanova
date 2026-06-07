using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Farmano.Repositories
{
    public class InventarioRepository
    {
        private string connectionString =
            "Host=localhost;Port=5432;Database=Farmano;Username=postgres;Password=postgres";

        public bool RegistrarEntrada(
    int idMedicamento,
    int cantidad)
        {
            try
            {
                using (NpgsqlConnection con =
                    new NpgsqlConnection(connectionString))
                {
                    con.Open();

                    string sqlMovimiento =
                    @"INSERT INTO movimientos_inventario
            (
                id_medicamento,
                tipo_movimiento,
                cantidad
            )
            VALUES
            (
                @id,
                'ENTRADA',
                @cantidad
            )";

                    NpgsqlCommand cmd1 =
                        new NpgsqlCommand(
                            sqlMovimiento,
                            con);

                    cmd1.Parameters.AddWithValue(
                        "@id",
                        idMedicamento);

                    cmd1.Parameters.AddWithValue(
                        "@cantidad",
                        cantidad);

                    cmd1.ExecuteNonQuery();

                    string sqlStock =
                    @"UPDATE medicamento
              SET stock = stock + @cantidad
              WHERE id_medicamento = @id";

                    NpgsqlCommand cmd2 =
                        new NpgsqlCommand(
                            sqlStock,
                            con);

                    cmd2.Parameters.AddWithValue(
                        "@cantidad",
                        cantidad);

                    cmd2.Parameters.AddWithValue(
                        "@id",
                        idMedicamento);

                    cmd2.ExecuteNonQuery();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool RegistrarSalida(
    int idMedicamento,
    int cantidad)
        {
            try
            {
                using (NpgsqlConnection con =
                    new NpgsqlConnection(connectionString))
                {
                    con.Open();

                    string sqlStockActual =
                    @"SELECT stock
              FROM medicamento
              WHERE id_medicamento=@id";

                    NpgsqlCommand cmdStock =
                        new NpgsqlCommand(
                            sqlStockActual,
                            con);

                    cmdStock.Parameters.AddWithValue(
                        "@id",
                        idMedicamento);

                    int stockActual =
                        Convert.ToInt32(
                            cmdStock.ExecuteScalar());

                    if (stockActual < cantidad)
                    {
                        return false;
                    }

                    string sqlMovimiento =
                    @"INSERT INTO movimientos_inventario
            (
                id_medicamento,
                tipo_movimiento,
                cantidad
            )
            VALUES
            (
                @id,
                'SALIDA',
                @cantidad
            )";

                    NpgsqlCommand cmd1 =
                        new NpgsqlCommand(
                            sqlMovimiento,
                            con);

                    cmd1.Parameters.AddWithValue(
                        "@id",
                        idMedicamento);

                    cmd1.Parameters.AddWithValue(
                        "@cantidad",
                        cantidad);

                    cmd1.ExecuteNonQuery();

                    string sqlUpdate =
                    @"UPDATE medicamento
              SET stock = stock - @cantidad
              WHERE id_medicamento = @id";

                    NpgsqlCommand cmd2 =
                        new NpgsqlCommand(
                            sqlUpdate,
                            con);

                    cmd2.Parameters.AddWithValue(
                        "@cantidad",
                        cantidad);

                    cmd2.Parameters.AddWithValue(
                        "@id",
                        idMedicamento);

                    cmd2.ExecuteNonQuery();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public DataTable ListarMovimientos()
        {
            DataTable tabla =
                new DataTable();

            try
            {
                using (NpgsqlConnection con =
                    new NpgsqlConnection(connectionString))
                {
                    con.Open();

                    string sql =
                    @"SELECT
                m.id_movimiento,
                md.nombre,
                m.tipo_movimiento,
                m.cantidad,
                m.fecha
            FROM movimientos_inventario m
            INNER JOIN medicamento md
                ON m.id_medicamento =
                   md.id_medicamento
            ORDER BY m.fecha DESC";

                    NpgsqlDataAdapter da =
                        new NpgsqlDataAdapter(
                            sql,
                            con);

                    da.Fill(tabla);
                }
            }
            catch
            {
            }

            return tabla;
        }
    }
}
