namespace SysEscuela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            btnRegistrar = new Button();
            dataGridView1 = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label4 = new Label();
            label6 = new Label();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtObservaciones = new TextBox();
            label9 = new Label();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            btnFormulario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 96);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 135);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 175);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(118, 132);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(174, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(118, 172);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(174, 23);
            txtEdad.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(40, 449);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(115, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Guardar Registro";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnGuardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(329, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(435, 330);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(173, 449);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(119, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Editar Registro";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(314, 449);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar Registro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(233, 18);
            label4.Name = "label4";
            label4.Size = new Size(315, 28);
            label4.TabIndex = 10;
            label4.Text = "Sistema de Registro de Estudiantes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 214);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 14;
            label6.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(118, 211);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(174, 23);
            txtTelefono.TabIndex = 15;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(118, 251);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(174, 23);
            txtDireccion.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 254);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 16;
            label7.Text = "Dirección";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 289);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 23);
            txtEmail.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 292);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 18;
            label8.Text = "Email";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(118, 330);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(174, 86);
            txtObservaciones.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 333);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 20;
            label9.Text = "Observaciones";
            label9.Click += label9_Click;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // btnFormulario
            // 
            btnFormulario.Location = new Point(459, 449);
            btnFormulario.Name = "btnFormulario";
            btnFormulario.Size = new Size(119, 23);
            btnFormulario.TabIndex = 22;
            btnFormulario.Text = "Generar Formulario";
            btnFormulario.UseVisualStyleBackColor = true;
            btnFormulario.Click += btnFormulario_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 501);
            Controls.Add(btnFormulario);
            Controls.Add(txtObservaciones);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(txtDireccion);
            Controls.Add(label7);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dataGridView1);
            Controls.Add(btnRegistrar);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Regsitro de Estudiantes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private Button btnRegistrar;
        private DataGridView dataGridView1;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label4;
        private Label label6;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtObservaciones;
        private Label label9;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button btnFormulario;
    }
}