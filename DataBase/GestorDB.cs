using CRUD_ADO.NET.Models;
using MySql.Data.MySqlClient;

namespace CRUD_ADO.NET.DataBase
{
    internal class GestorDB
    {
        private Connection conn;

        public GestorDB()
        {
            conn = new Connection();
        }

        public bool DeleteUser(int userId)
        {
            using (MySqlConnection connection = conn.GetConnection())
            {
                try
                {
                    string query = "DELETE FROM Usuario WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("Id", userId);
                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al borrar el usuario: " + ex.Message);
                }

            }
        }

        public bool isUser(int userId) 
        {
            return GetUserById(userId) != null;
        }

        public Usuario GetUserById(int userId)
        {
            using (MySqlConnection connection = conn.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Usuario WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("Id", userId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = reader.GetInt32("Id"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido"),
                                NombreUsuario = reader.GetString("NombreUsuario"),
                                Password = reader.GetString("Contraseña"),
                                Email = reader.GetString("Mail")

                            };
                            return usuario;
                        }
                        else
                        {
                            return null;
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el usuario: " + ex.Message);
                }
            }
        }

        public int CreateUser(Usuario usuario)
        {
            using (MySqlConnection connection = conn.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO Usuario(Nombre,Apellido,NombreUsuario,Contraseña,Mail) values(@Nombre,@Apellido,@User,@Pass,@Mail)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("Apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("User", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("Pass", usuario.Password);
                    command.Parameters.AddWithValue("Mail", usuario.Email);
                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT LAST_INSERT_ID()";
                    int IdUser = Convert.ToInt32(command.ExecuteScalar());
                    return IdUser;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el usuario: " + ex.Message);
                }
            }
        }

        public bool UpdateUser(int userId, Usuario usuario)
        {
            using (MySqlConnection connection = conn.GetConnection())
            {
                try
                {
                    string query = "UPDATE Usuario SET Nombre = @Nombre,Apellido = @Apellido,NombreUsuario = @User,Contraseña = @Pass,Mail = @Mail WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("Apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("User", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("Pass", usuario.Password);
                    command.Parameters.AddWithValue("Mail", usuario.Email);
                    command.Parameters.AddWithValue("Id", userId);
                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el usuario: " + ex.Message);
                }

            }
        }

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (MySqlConnection connection = conn.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Usuario";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = reader.GetInt32("Id"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido"),
                                NombreUsuario = reader.GetString("NombreUsuario"),
                                Password = reader.GetString("Contraseña"),
                                Email = reader.GetString("Mail")
                            };
                            usuarios.Add(usuario);
                        }
                    }

                    return usuarios;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar la lista de usuarios: " + ex.Message);
                }

            }
        }

    }
}
