namespace CapaPresentacion2
{
    partial class Registrarse
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.R_correo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.R_clave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.R_apP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.R_nombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.R_apM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.NACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.genero_F = new System.Windows.Forms.RadioButton();
            this.genero_M = new System.Windows.Forms.RadioButton();
            this.genero_default = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo electronico";
            // 
            // R_correo
            // 
            this.R_correo.BackColor = System.Drawing.Color.White;
            this.R_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_correo.Location = new System.Drawing.Point(29, 64);
            this.R_correo.Name = "R_correo";
            this.R_correo.Size = new System.Drawing.Size(248, 26);
            this.R_correo.TabIndex = 1;
            this.R_correo.Tag = "R_CorreoElectronico";
            this.R_correo.TextChanged += new System.EventHandler(this.R_correo_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 80);
            this.label2.TabIndex = 2;
            // 
            // R_clave
            // 
            this.R_clave.BackColor = System.Drawing.Color.White;
            this.R_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_clave.Location = new System.Drawing.Point(29, 160);
            this.R_clave.Name = "R_clave";
            this.R_clave.PasswordChar = '*';
            this.R_clave.Size = new System.Drawing.Size(248, 26);
            this.R_clave.TabIndex = 4;
            this.R_clave.Tag = "R_Contrasena";
            this.R_clave.TextChanged += new System.EventHandler(this.R_clave_TextChanged);
            this.R_clave.Validating += new System.ComponentModel.CancelEventHandler(this.R_clave_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 80);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha De Nacimiento";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(21, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 80);
            this.label6.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Genero";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(21, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 120);
            this.label8.TabIndex = 12;
            // 
            // R_apP
            // 
            this.R_apP.BackColor = System.Drawing.Color.White;
            this.R_apP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_apP.Location = new System.Drawing.Point(317, 160);
            this.R_apP.Name = "R_apP";
            this.R_apP.Size = new System.Drawing.Size(248, 26);
            this.R_apP.TabIndex = 18;
            this.R_apP.Tag = "R_ApellidoP";
            this.R_apP.Validating += new System.ComponentModel.CancelEventHandler(this.R_apP_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Apellido Paterno";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(309, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 80);
            this.label10.TabIndex = 19;
            // 
            // R_nombre
            // 
            this.R_nombre.BackColor = System.Drawing.Color.White;
            this.R_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_nombre.Location = new System.Drawing.Point(317, 64);
            this.R_nombre.Name = "R_nombre";
            this.R_nombre.Size = new System.Drawing.Size(248, 26);
            this.R_nombre.TabIndex = 15;
            this.R_nombre.Tag = "R_Nombre";
            this.R_nombre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.R_nombre.Validating += new System.ComponentModel.CancelEventHandler(this.R_nombre_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(317, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(309, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 80);
            this.label12.TabIndex = 16;
            // 
            // R_apM
            // 
            this.R_apM.BackColor = System.Drawing.Color.White;
            this.R_apM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_apM.Location = new System.Drawing.Point(317, 256);
            this.R_apM.Name = "R_apM";
            this.R_apM.Size = new System.Drawing.Size(248, 26);
            this.R_apM.TabIndex = 21;
            this.R_apM.Tag = "R_ApellidoM";
            this.R_apM.Validating += new System.ComponentModel.CancelEventHandler(this.R_apM_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(317, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Apellido Materno";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(309, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(272, 80);
            this.label14.TabIndex = 22;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LavenderBlush;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.LightPink;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 15;
            this.iconButton1.Location = new System.Drawing.Point(312, 397);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(269, 32);
            this.iconButton1.TabIndex = 46;
            this.iconButton1.Tag = "Aceptar_registro";
            this.iconButton1.Text = "Aceptar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // NACIMIENTO
            // 
            this.NACIMIENTO.CustomFormat = "yyyy.MM.dd";
            this.NACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NACIMIENTO.Location = new System.Drawing.Point(29, 262);
            this.NACIMIENTO.MaxDate = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            this.NACIMIENTO.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.NACIMIENTO.Name = "NACIMIENTO";
            this.NACIMIENTO.Size = new System.Drawing.Size(248, 20);
            this.NACIMIENTO.TabIndex = 47;
            this.NACIMIENTO.Value = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            this.NACIMIENTO.ValueChanged += new System.EventHandler(this.NACIMIENTO_ValueChanged);
            this.NACIMIENTO.Validating += new System.ComponentModel.CancelEventHandler(this.NACIMIENTO_Validating);
            // 
            // genero_F
            // 
            this.genero_F.AutoSize = true;
            this.genero_F.Location = new System.Drawing.Point(29, 348);
            this.genero_F.Name = "genero_F";
            this.genero_F.Size = new System.Drawing.Size(71, 17);
            this.genero_F.TabIndex = 48;
            this.genero_F.TabStop = true;
            this.genero_F.Text = "Femenino";
            this.genero_F.UseVisualStyleBackColor = true;
            // 
            // genero_M
            // 
            this.genero_M.AutoSize = true;
            this.genero_M.Location = new System.Drawing.Point(29, 371);
            this.genero_M.Name = "genero_M";
            this.genero_M.Size = new System.Drawing.Size(73, 17);
            this.genero_M.TabIndex = 49;
            this.genero_M.TabStop = true;
            this.genero_M.Text = "Masculino";
            this.genero_M.UseVisualStyleBackColor = true;
            // 
            // genero_default
            // 
            this.genero_default.AutoSize = true;
            this.genero_default.Location = new System.Drawing.Point(29, 394);
            this.genero_default.Name = "genero_default";
            this.genero_default.Size = new System.Drawing.Size(95, 17);
            this.genero_default.TabIndex = 50;
            this.genero_default.TabStop = true;
            this.genero_default.Text = "Sin Especificar";
            this.genero_default.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(163, 341);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 70);
            this.label15.TabIndex = 51;
            this.label15.Text = "Si no se ingresa ningun genero, se utilizara \"Sin especificar\"";
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(646, 495);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.genero_default);
            this.Controls.Add(this.genero_M);
            this.Controls.Add(this.genero_F);
            this.Controls.Add(this.NACIMIENTO);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.R_apM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.R_apP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.R_nombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.R_clave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.R_correo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Registrarse";
            this.Tag = "Registro_usuario";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox R_correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox R_clave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox R_apP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox R_nombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox R_apM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker NACIMIENTO;
        private System.Windows.Forms.RadioButton genero_F;
        private System.Windows.Forms.RadioButton genero_M;
        private System.Windows.Forms.RadioButton genero_default;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label15;
    }
}