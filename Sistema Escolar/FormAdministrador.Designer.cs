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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtBoxApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApelidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxTipoUser = new System.Windows.Forms.ComboBox();
            this.btnAgregarMaestros = new System.Windows.Forms.Button();
            this.btnLimpiarMaestros = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridMaestros = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageAlumnos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaestros)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAlumnos);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 202);
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
            this.tabPageAlumnos.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAlumnos.Name = "tabPageAlumnos";
            this.tabPageAlumnos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAlumnos.Size = new System.Drawing.Size(528, 176);
            this.tabPageAlumnos.TabIndex = 0;
            this.tabPageAlumnos.Text = "Alumnos";
            this.tabPageAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(396, 23);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 51);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Clear.Location = new System.Drawing.Point(396, 90);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(109, 51);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Limpiar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefono.Location = new System.Drawing.Point(138, 112);
            this.txtBoxTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTelefono.MaxLength = 10;
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(240, 23);
            this.txtBoxTelefono.TabIndex = 9;
            // 
            // txtBoxApellidoMaterno
            // 
            this.txtBoxApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApellidoMaterno.Location = new System.Drawing.Point(138, 86);
            this.txtBoxApellidoMaterno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxApellidoMaterno.MaxLength = 50;
            this.txtBoxApellidoMaterno.Name = "txtBoxApellidoMaterno";
            this.txtBoxApellidoMaterno.Size = new System.Drawing.Size(240, 23);
            this.txtBoxApellidoMaterno.TabIndex = 8;
            // 
            // txtBoxApellidoPaterno
            // 
            this.txtBoxApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApellidoPaterno.Location = new System.Drawing.Point(138, 60);
            this.txtBoxApellidoPaterno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxApellidoPaterno.MaxLength = 50;
            this.txtBoxApellidoPaterno.Name = "txtBoxApellidoPaterno";
            this.txtBoxApellidoPaterno.Size = new System.Drawing.Size(240, 23);
            this.txtBoxApellidoPaterno.TabIndex = 7;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.Location = new System.Drawing.Point(138, 34);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(240, 23);
            this.txtBoxNombre.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(69, 114);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(22, 88);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(114, 17);
            this.lblApellidoMaterno.TabIndex = 3;
            this.lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // lblApelidoPaterno
            // 
            this.lblApelidoPaterno.AutoSize = true;
            this.lblApelidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelidoPaterno.Location = new System.Drawing.Point(25, 62);
            this.lblApelidoPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApelidoPaterno.Name = "lblApelidoPaterno";
            this.lblApelidoPaterno.Size = new System.Drawing.Size(112, 17);
            this.lblApelidoPaterno.TabIndex = 2;
            this.lblApelidoPaterno.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(74, 36);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxTipoUser);
            this.tabPage2.Controls.Add(this.btnAgregarMaestros);
            this.tabPage2.Controls.Add(this.btnLimpiarMaestros);
            this.tabPage2.Controls.Add(this.txtBoxPassword);
            this.tabPage2.Controls.Add(this.txtBoxUsername);
            this.tabPage2.Controls.Add(this.lblTipoUser);
            this.tabPage2.Controls.Add(this.lblPassword);
            this.tabPage2.Controls.Add(this.lblUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(528, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maestros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipoUser
            // 
            this.comboBoxTipoUser.FormattingEnabled = true;
            this.comboBoxTipoUser.Items.AddRange(new object[] {
            "Administrador",
            "Maestro"});
            this.comboBoxTipoUser.Location = new System.Drawing.Point(127, 99);
            this.comboBoxTipoUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTipoUser.Name = "comboBoxTipoUser";
            this.comboBoxTipoUser.Size = new System.Drawing.Size(240, 21);
            this.comboBoxTipoUser.TabIndex = 17;
            // 
            // btnAgregarMaestros
            // 
            this.btnAgregarMaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarMaestros.Location = new System.Drawing.Point(402, 21);
            this.btnAgregarMaestros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarMaestros.Name = "btnAgregarMaestros";
            this.btnAgregarMaestros.Size = new System.Drawing.Size(109, 51);
            this.btnAgregarMaestros.TabIndex = 15;
            this.btnAgregarMaestros.Text = "Agregar";
            this.btnAgregarMaestros.UseVisualStyleBackColor = true;
            this.btnAgregarMaestros.Click += new System.EventHandler(this.btnAgregarMaestros_Click);
            // 
            // btnLimpiarMaestros
            // 
            this.btnLimpiarMaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpiarMaestros.Location = new System.Drawing.Point(402, 88);
            this.btnLimpiarMaestros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarMaestros.Name = "btnLimpiarMaestros";
            this.btnLimpiarMaestros.Size = new System.Drawing.Size(109, 51);
            this.btnLimpiarMaestros.TabIndex = 16;
            this.btnLimpiarMaestros.Text = "Limpiar";
            this.btnLimpiarMaestros.UseVisualStyleBackColor = true;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(127, 71);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPassword.MaxLength = 50;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(240, 23);
            this.txtBoxPassword.TabIndex = 13;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.Location = new System.Drawing.Point(127, 45);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxUsername.MaxLength = 50;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(240, 23);
            this.txtBoxUsername.TabIndex = 12;
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUser.Location = new System.Drawing.Point(75, 99);
            this.lblTipoUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(45, 17);
            this.lblTipoUser.TabIndex = 11;
            this.lblTipoUser.Text = "Labor";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(40, 73);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 17);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(63, 47);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 17);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Usuario";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(0, 1);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(525, 239);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(517, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(517, 213);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Visualizar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Location = new System.Drawing.Point(2, 2);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(514, 202);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridAlumnos);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Size = new System.Drawing.Size(506, 176);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Alumnos";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridAlumnos
            // 
            this.dataGridAlumnos.AllowUserToAddRows = false;
            this.dataGridAlumnos.AllowUserToDeleteRows = false;
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Location = new System.Drawing.Point(4, 4);
            this.dataGridAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.ReadOnly = true;
            this.dataGridAlumnos.RowHeadersWidth = 62;
            this.dataGridAlumnos.RowTemplate.Height = 28;
            this.dataGridAlumnos.Size = new System.Drawing.Size(501, 173);
            this.dataGridAlumnos.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridMaestros);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage7.Size = new System.Drawing.Size(506, 176);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Maestros";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridMaestros
            // 
            this.dataGridMaestros.AllowUserToAddRows = false;
            this.dataGridMaestros.AllowUserToDeleteRows = false;
            this.dataGridMaestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaestros.Location = new System.Drawing.Point(4, 4);
            this.dataGridMaestros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridMaestros.Name = "dataGridMaestros";
            this.dataGridMaestros.ReadOnly = true;
            this.dataGridMaestros.RowHeadersWidth = 62;
            this.dataGridMaestros.RowTemplate.Height = 28;
            this.dataGridMaestros.Size = new System.Drawing.Size(501, 173);
            this.dataGridMaestros.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(517, 213);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Editar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(517, 213);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Eliminar";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dgv2);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(517, 213);
            this.tabPage8.TabIndex = 4;
            this.tabPage8.Text = "JOIN";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.dgv3);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(517, 213);
            this.tabPage9.TabIndex = 5;
            this.tabPage9.Text = "Vistas";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(34, 6);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(389, 197);
            this.dgv2.TabIndex = 0;
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(8, 6);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(456, 184);
            this.dgv3.TabIndex = 0;
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 238);
            this.Controls.Add(this.tabControl2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdministrador";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlumnos.ResumeLayout(false);
            this.tabPageAlumnos.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaestros)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
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
        private System.Windows.Forms.Button btnAgregarMaestros;
        private System.Windows.Forms.Button btnLimpiarMaestros;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblTipoUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox comboBoxTipoUser;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridMaestros;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView dgv3;
    }
}