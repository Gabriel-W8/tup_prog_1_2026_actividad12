namespace Actividad_12
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.tbLU = new System.Windows.Forms.TextBox();
            this.lbLU = new System.Windows.Forms.Label();
            this.btnBuscarYVerAlumno = new System.Windows.Forms.Button();
            this.btnMostrarListadoOrdenado = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnRegistrarAlumno);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(282, 90);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Solicitud datos alumno";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnBuscarYVerAlumno);
            this.GroupBox2.Controls.Add(this.lbLU);
            this.GroupBox2.Controls.Add(this.tbLU);
            this.GroupBox2.Location = new System.Drawing.Point(12, 108);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(282, 81);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Salidas";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnMostrarListadoOrdenado);
            this.GroupBox3.Location = new System.Drawing.Point(12, 195);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(282, 99);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Salidas";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(48, 33);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(133, 26);
            this.btnRegistrarAlumno.TabIndex = 0;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // tbLU
            // 
            this.tbLU.Location = new System.Drawing.Point(49, 23);
            this.tbLU.Name = "tbLU";
            this.tbLU.Size = new System.Drawing.Size(100, 20);
            this.tbLU.TabIndex = 0;
            // 
            // lbLU
            // 
            this.lbLU.AutoSize = true;
            this.lbLU.Location = new System.Drawing.Point(19, 26);
            this.lbLU.Name = "lbLU";
            this.lbLU.Size = new System.Drawing.Size(24, 13);
            this.lbLU.TabIndex = 1;
            this.lbLU.Text = "LU:";
            // 
            // btnBuscarYVerAlumno
            // 
            this.btnBuscarYVerAlumno.Location = new System.Drawing.Point(180, 21);
            this.btnBuscarYVerAlumno.Name = "btnBuscarYVerAlumno";
            this.btnBuscarYVerAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarYVerAlumno.TabIndex = 2;
            this.btnBuscarYVerAlumno.Text = "Buscar";
            this.btnBuscarYVerAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarYVerAlumno.Click += new System.EventHandler(this.btnBuscarYVerAlumno_Click);
            // 
            // btnMostrarListadoOrdenado
            // 
            this.btnMostrarListadoOrdenado.Location = new System.Drawing.Point(48, 29);
            this.btnMostrarListadoOrdenado.Name = "btnMostrarListadoOrdenado";
            this.btnMostrarListadoOrdenado.Size = new System.Drawing.Size(133, 28);
            this.btnMostrarListadoOrdenado.TabIndex = 0;
            this.btnMostrarListadoOrdenado.Text = "Mostrar Listado";
            this.btnMostrarListadoOrdenado.UseVisualStyleBackColor = true;
            this.btnMostrarListadoOrdenado.Click += new System.EventHandler(this.btnMostrarListadoOrdenado_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 311);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad 12";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Button btnBuscarYVerAlumno;
        private System.Windows.Forms.Label lbLU;
        private System.Windows.Forms.TextBox tbLU;
        private System.Windows.Forms.Button btnMostrarListadoOrdenado;
    }
}

