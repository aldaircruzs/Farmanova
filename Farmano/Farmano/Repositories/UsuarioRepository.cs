using Farmano.Models;
using Npgsql;
using System;

namespace Farmano.Repositories
{
    public class UsuarioRepository
    {
        ConexionBD conexion =
        new ConexionBD();

        public Usuario Login(
            string usuario,
            string password)
        {
            Usuario user = null;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                @"SELECT * 
                  FROM Usuarios
                  WHERE Usuario=@usuario
                  AND Contrasena=@password";

                NpgsqlCommand cmd =
                new NpgsqlCommand(
                    consulta,
                    cn);

                cmd.Parameters.AddWithValue(
                    "@usuario",
                    usuario);

                cmd.Parameters.AddWithValue(
                    "@password",
                    password);

                NpgsqlDataReader dr =
                cmd.ExecuteReader();

                if (dr.Read())
                {
                    user = new Usuario();

                    user.Id =
                    Convert.ToInt32(dr["Id"]);

                    user.Nombre =
                    dr["Nombre"].ToString();

                    user.Apellidos =
                    dr["Apellidos"].ToString();

                    user.Correo =
                    dr["Correo"].ToString();

                    user.Telefono =
                    dr["Telefono"].ToString();
                }
            }

            return user;
        }
        public bool Registrar(Usuario usuario)
        {
            bool registrado = false;

            using (var cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                @"INSERT INTO Usuarios
        (
            Nombre,
            Apellidos,
            Correo,
            Telefono,
            Usuario,
            Contrasena
        )

        VALUES
        (
            @nombre,
            @apellidos,
            @correo,
            @telefono,
            @usuario,
            @contrasena
        )";

                NpgsqlCommand cmd =
                new NpgsqlCommand(
                    consulta,
                    cn);

                cmd.Parameters.AddWithValue(
                    "@nombre",
                    usuario.Nombre);

                cmd.Parameters.AddWithValue(
                    "@apellidos",
                    usuario.Apellidos);

                cmd.Parameters.AddWithValue(
                    "@correo",
                    usuario.Correo);

                cmd.Parameters.AddWithValue(
                    "@telefono",
                    usuario.Telefono);

                cmd.Parameters.AddWithValue(
                    "@usuario",
                    usuario.UsuarioLogin);

                cmd.Parameters.AddWithValue(
                    "@contrasena",
                    usuario.Contraseña);

                // Ejecutar la inserción y establecer el resultado
                int filasAfectadas = cmd.ExecuteNonQuery();
                registrado = filasAfectadas > 0;
            }

            return registrado;
        }
    }
}