using Npgsql;

public class ConexionBD
{
    private string cadena =

    "Host=localhost;" +
    "Port=5432;" +
    "Database=farmanova_respaldo;" +
    "Username=postgres;" +
    "Password=postgres";

    public NpgsqlConnection ObtenerConexion()
    {
        return new NpgsqlConnection(cadena);
    }
}