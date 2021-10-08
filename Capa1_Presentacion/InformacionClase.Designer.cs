
namespace Presentacion.Winform.ModuloInscripcion
{
    partial class InformacionClase
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
            this.txtProfesorAsignado = new System.Windows.Forms.TextBox();
            this.txtHorarios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNumeroClase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProfesorAsignado
            // 
            this.txtProfesorAsignado.Location = new System.Drawing.Point(129, 63);
            this.txtProfesorAsignado.Name = "txtProfesorAsignado";
            this.txtProfesorAsignado.Size = new System.Drawing.Size(175, 20);
            this.txtProfesorAsignado.TabIndex = 15;
            // 
            // txtHorarios
            // 
            this.txtHorarios.Location = new System.Drawing.Point(82, 100);
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(222, 20);
            this.txtHorarios.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Horarios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Profesor Asignado:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(129, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 31);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtNumeroClase
            // 
            this.txtNumeroClase.Location = new System.Drawing.Point(123, 28);
            this.txtNumeroClase.Name = "txtNumeroClase";
            this.txtNumeroClase.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroClase.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero de clase:";
            // 
            // InformacionClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 202);
            this.Controls.Add(this.txtProfesorAsignado);
            this.Controls.Add(this.txtHorarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNumeroClase);
            this.Controls.Add(this.label1);
            this.Name = "InformacionClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion de la Clase";
            this.Load += new System.EventHandler(this.InformacionClase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProfesorAsignado;
        private System.Windows.Forms.TextBox txtHorarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNumeroClase;
        private System.Windows.Forms.Label label1;
    }
}