using Microsoft.Reporting.WinForms;
using System.Data;
using System.Data.SqlClient;

namespace SysEscuela
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        string UID = "";

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Conexion con = new Conexion();
            //con.ActualizarGrid(this.dataGridView1, "Select * from Alumno");
            dataGridView1.DataSource = Conexion.LeerDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (UID == "")
            {
                if (Conexion.Guardar_Registro(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtTelefono.Text, txtDireccion.Text, txtEmail.Text, txtObservaciones.Text))
                {
                    MessageBox.Show("El Registro se ha Guardado Correctamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = Conexion.LeerDatos();

                }
                else
                {
                    MessageBox.Show("El Registro NO se ha Guardado", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (Conexion.Actualizar_Registro(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtTelefono.Text, txtDireccion.Text, txtEmail.Text, txtObservaciones.Text, UID))
                {
                    MessageBox.Show("El Registro se ha Actualizado Correctamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = Conexion.LeerDatos();

                }
                else
                {
                    MessageBox.Show("El Registro NO se ha Actualizado", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtObservaciones.Text = "";
            UID = "";

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                string ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                string Nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                string Apellido = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                string Edad = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                string Telefono = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                string Direccion = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                string Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                string Observaciones = dataGridView1.CurrentRow.Cells["Observaciones"].Value.ToString();
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                txtEdad.Text = Edad;
                txtTelefono.Text = Telefono;
                txtDireccion.Text = Direccion;
                txtEmail.Text = Email;
                txtObservaciones.Text = Observaciones;
                UID = ID;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún registro,\n Por favor seleccione un registro", "Advertencia del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            if (Conexion.Borrar_Registro(ID))
            {
                MessageBox.Show("El Registro se ha Eliminado Correctamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = Conexion.LeerDatos();

            }
            else
            {
                MessageBox.Show("El Registro NO se ha Eliminado", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N10B9GL;Initial Catalog=EscuelaDB;Integrated Security=True");

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            VisorInformes Mostrar = new VisorInformes();
            Mostrar.ShowDialog();
            // ReportDataSource ReportDataSourceReporte;
            // DataSetAlumnos ds = new DataSetAlumnos();
            // var DAtmp = new
            //DatosReporteTableAdapters.Orden_x_IDTableAdapter();
            // ReportDataSourceReporte = new ReportDataSource();
            // var dt = new DatosReporte.Orden_x_IDDataTable();
            // DAtmp.Fill(dt, Convert.ToInt32(txtOrdenID.Text));
            // dt.TableName = "ReporteAlumnos";
            // ds.Tables.Add(dt);
            // var frm = new VisorInformes();
            // frm.vistaPreliminar(ds, "dsOrdenesId",
            //"AplicacionCapas.rptOrdenesID.rdlc");
            // frm.ShowDialog();
            // //this.Close();

            //SqlCommand comm = new SqlCommand("Select * from Alumno", connection);
            //SqlDataAdapter d = new SqlDataAdapter(comm);
            //DataTable dt = new DataTable();
            //d.Fill(dt);

            //reportViewer1.LocalReport.DataSources.Clear();
            //ReportDataSource source = new ReportDataSource("DataSetAlumnos",dt);
            //reportViewer1.LocalReport.ReportPath = "ReporteAlumnos.rdlc";
            //reportViewer1.LocalReport.DataSources.Add(source);
            //reportViewer1.RefreshReport();

        }
    }
}