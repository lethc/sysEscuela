using System.Data;
using System.Data.SqlClient;

namespace SysEscuela
{
    internal class Conexion
    {

        static string ConnectionString = @"Data Source=DESKTOP-N10B9GL;Initial Catalog=EscuelaDB;Integrated Security=True";
        public static DataTable LeerDatos()
        {
            DataTable dt_ListaPersonas = new DataTable();

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand comm = new SqlCommand("Select * from Alumno", conn);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dt_ListaPersonas);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt_ListaPersonas;
        }

        public static bool Guardar_Registro(string Nombre, string Apellido, string Edad, string Telefono, string Direccion, string Email, string Observaciones)
        {
            bool Exito = false;
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand comm = new SqlCommand("INSERT INTO Alumno (nombre, apellido, edad, telefono, direccion, email,observaciones) VALUES(@Nombre,@Apellido,@Edad,@Telefono,@Direccion,@Email,@Observaciones)", conn);
            comm.Parameters.AddWithValue("@Nombre", Nombre);
            comm.Parameters.AddWithValue("@Apellido", Apellido);
            comm.Parameters.AddWithValue("@Edad", Edad);
            comm.Parameters.AddWithValue("@Telefono", Telefono);
            comm.Parameters.AddWithValue("@Direccion", Direccion);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Observaciones", Observaciones);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                Exito = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return Exito;
        }

        public static bool Actualizar_Registro(string Nombre, string Apellido, string Edad, string Telefono, string Direccion, string Email, string Observaciones, string ID)
        {
            bool Exito = false;
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand comm = new SqlCommand("UPDATE Alumno set nombre=@Nombre,apellido=@Apellido,edad=@Edad,telefono=@Telefono,direccion=@Direccion,email=@Email,observaciones=@Observaciones WHERE id=@ID;", conn);
            comm.Parameters.AddWithValue("@ID", ID);
            comm.Parameters.AddWithValue("@Nombre", Nombre);
            comm.Parameters.AddWithValue("@Apellido", Apellido);
            comm.Parameters.AddWithValue("@Edad", Edad);
            comm.Parameters.AddWithValue("@Telefono", Telefono);
            comm.Parameters.AddWithValue("@Direccion", Direccion);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Observaciones", Observaciones);


            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                Exito = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return Exito;
        }

        public static bool Borrar_Registro(string ID)
        {
            bool Exito = false;
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand comm = new SqlCommand("DELETE FROM Alumno WHERE id=@ID;", conn);
            comm.Parameters.AddWithValue("@ID", ID);


            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                Exito = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return Exito;
        }

        //SqlConnection conn;

        //public void Conectar()
        //{
        //    conn = new SqlConnection("Data Source=DESKTOP-N10B9GL;Initial Catalog=EscuelaDB;Integrated Security=True");
        //    conn.Open();
        //}

        //public void Desconectar() 
        //{
        //    conn.Close();
        //}

        //public void EjecutarSql(String consulta) 
        //{
        //    SqlCommand conn = new SqlCommand(consulta, conn);
        //    int filasAfectadas = conn.ExecuteNonQuery();

        //    if (filasAfectadas > 0)
        //        MessageBox.Show("Operación realizada Correctamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    else
        //        MessageBox.Show("No se ha conectado a la base de datos", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


        //}

        //public void ActualizarGrid(DataGridView dg, String consulta)
        //{
        //    this.Conectar();

        //    System.Data.DataSet ds = new System.Data.DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter(consulta, conn);

        //    da.Fill(ds, "Alumno");

        //    dg.DataSource = ds;
        //    dg.DataMember = "Alumno";

        //    this.Desconectar();
        //}

    }
}
