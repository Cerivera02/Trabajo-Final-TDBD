namespace Sistema_Escolar
{
    partial class FormAdministrador
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAlumnos = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApelidoPaterno = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtBoxApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAlumnos);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 311);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageAlumnos
            // 
            this.tabPageAlumnos.Controls.Add(this.btnAgregar);
            this.tabPageAlumnos.Controls.Add(this.btn_Clear);
            this.tabPageAlumnos.Controls.Add(this.txtBoxTelefono);
            this.tabPageAlumnos.Controls.Add(this.txtBoxApellidoMaterno);
            this.tabPageAlumnos.Controls.Add(this.txtBoxApellidoPaterno);
            this.tabPageAlumnos.Controls.Add(this.txtBoxNombre);
            this.tabPageAlumnos.Controls.Add(this.lblTelefono);
            this.tabPageAlumnos.Controls.Add(this.lblApellidoMaterno);
            this.tabPageAlumnos.Controls.Add(this.lblApelidoPaterno);
            this.tabPageAlumnos.Controls.Add(this.lblNombre);
            this.tabPageAlumnos.Location = new System.Drawing.Point(4, 29);
            this.tabPageAlumnos.Name = "tabPageAlumnos";
            this.tabPageAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlumnos.Size = new System.Drawing.Size(796, 278);
            this.tabPageAlumnos.TabIndex = 0;
            this.tabPageAlumnos.Text = "Registro Alumnos";
            this.tabPageAlumnos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro Maestros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(111, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(33, 136);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(159, 25);
            this.lblApellidoMaterno.TabIndex = 3;
            this.lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // lblApelidoPaterno
            // 
            this.lblApelidoPaterno.AutoSize = true;
            this.lblApelidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelidoPaterno.Location = new System.Drawing.Point(37, 96);
            this.lblApelidoPaterno.Name = "lblApelidoPaterno";
            this.lblApelidoPaterno.Size = new System.Drawing.Size(155, 25);
            this.lblApelidoPaterno.TabIndex = 2;
            this.lblApelidoPaterno.Text = "Apellido Paterno";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(103, 175);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 25);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.Location = new System.Drawing.Point(207, 53);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(358, 30);
            this.txtBoxNombre.TabIndex = 6;
            // 
            // txtBoxApellidoPaterno
            // 
            this.txtBoxApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApellidoPaterno.Location = new System.Drawing.Point(207, 93);
            this.txtBoxApellidoPaterno.MaxLength = 50;
            this.txtBoxApellidoPaterno.Name = "txtBoxApellidoPaterno";
            this.txtBoxApellidoPaterno.Size = new System.Drawing.Size(358, 30);
            this.txtBoxApellidoPaterno.TabIndex = 7;
            // 
            // txtBoxApellidoMaterno
            // 
            this.txtBoxApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApellidoMaterno.Location = new System.Drawing.Point(207, 133);
            this.txtBoxApellidoMaterno.MaxLength = 50;
            this.txtBoxApellidoMaterno.Name = "txtBoxApellidoMaterno";
            this.txtBoxApellidoMaterno.Size = new System.Drawing.Size(358, 30);
            this.txtBoxApellidoMaterno.TabIndex = 8;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefono.Location = new System.Drawing.Point(207, 172);
            this.txtBoxTelefono.MaxLength = 10;
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(358, 30);
            this.txtBoxTelefono.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(594, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 78);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Clear.Location = new System.Drawing.Point(594, 138);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(163, 78);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Limpiar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdministrador";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlumnos.ResumeLayout(false);
            this.tabPageAlumnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAlumnos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApelidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxApellidoMaterno;
        private System.Windows.Forms.TextBox txtBoxApellidoPaterno;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btn_Clear;
    }
}