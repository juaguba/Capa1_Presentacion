
namespace Presentacion.Winform.ModuloInscripcion
{
    partial class RealizarInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtFechaNacimientoAlumno = new System.Windows.Forms.TextBox();
            this.txtCelularAlumno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroClase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.btnInfoClase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClase = new System.Windows.Forms.DataGridView();
            this.IdClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscritos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(367, 198);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 60;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // txtFechaNacimientoAlumno
            // 
            this.txtFechaNacimientoAlumno.Location = new System.Drawing.Point(162, 374);
            this.txtFechaNacimientoAlumno.Name = "txtFechaNacimientoAlumno";
            this.txtFechaNacimientoAlumno.Size = new System.Drawing.Size(138, 20);
            this.txtFechaNacimientoAlumno.TabIndex = 59;
            // 
            // txtCelularAlumno
            // 
            this.txtCelularAlumno.Location = new System.Drawing.Point(394, 374);
            this.txtCelularAlumno.Name = "txtCelularAlumno";
            this.txtCelularAlumno.Size = new System.Drawing.Size(129, 20);
            this.txtCelularAlumno.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Num. Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = " Fecha de nacimiento:";
            // 
            // txtNumeroClase
            // 
            this.txtNumeroClase.Location = new System.Drawing.Point(142, 231);
            this.txtNumeroClase.Name = "txtNumeroClase";
            this.txtNumeroClase.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroClase.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Numero de clase:";
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(182, 260);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumno.TabIndex = 53;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // btnInfoClase
            // 
            this.btnInfoClase.Location = new System.Drawing.Point(448, 198);
            this.btnInfoClase.Name = "btnInfoClase";
            this.btnInfoClase.Size = new System.Drawing.Size(75, 23);
            this.btnInfoClase.TabIndex = 52;
            this.btnInfoClase.Text = "Info. Clase";
            this.btnInfoClase.UseVisualStyleBackColor = true;
            this.btnInfoClase.Click += new System.EventHandler(this.btnInfoClase_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Datos de inscripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Buscar Cursos";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(110, 337);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(413, 20);
            this.txtDireccionAlumno.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Direccion:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(99, 297);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(158, 20);
            this.txtNombreAlumno.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombres:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(306, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 33);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(216, 420);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 33);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Location = new System.Drawing.Point(81, 262);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(95, 20);
            this.txtDniAlumno.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "DNI:";
            // 
            // dgvClase
            // 
            this.dgvClase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClase,
            this.Inscritos,
            this.Capacidad,
            this.Fecha});
            this.dgvClase.Location = new System.Drawing.Point(40, 77);
            this.dgvClase.Name = "dgvClase";
            this.dgvClase.Size = new System.Drawing.Size(483, 103);
            this.dgvClase.TabIndex = 41;
            // 
            // IdClase
            // 
            this.IdClase.HeaderText = "Numero de Clase";
            this.IdClase.Name = "IdClase";
            this.IdClase.Width = 110;
            // 
            // Inscritos
            // 
            this.Inscritos.HeaderText = "Alumnos inscritos";
            this.Inscritos.Name = "Inscritos";
            this.Inscritos.Width = 110;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Total permitido";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Width = 110;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha límite";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre Curso:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(125, 51);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(94, 20);
            this.txtNombreCurso.TabIndex = 39;
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Location = new System.Drawing.Point(225, 48);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCurso.TabIndex = 38;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Apellidos:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(331, 297);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(192, 20);
            this.txtApellidoAlumno.TabIndex = 62;
            // 
            // RealizarInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 470);
            this.Controls.Add(this.txtApellidoAlumno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtFechaNacimientoAlumno);
            this.Controls.Add(this.txtCelularAlumno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumeroClase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.btnInfoClase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDireccionAlumno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDniAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.btnBuscarCurso);
            this.Name = "RealizarInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Inscripcion";
            this.Load += new System.EventHandler(this.RealizarInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtFechaNacimientoAlumno;
        private System.Windows.Forms.TextBox txtCelularAlumno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroClase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Button btnInfoClase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDniAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
    }
}