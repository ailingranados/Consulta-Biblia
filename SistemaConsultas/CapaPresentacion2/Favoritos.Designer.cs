namespace CapaPresentacion2
{
    partial class Favoritos
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
            this.DGV_Favoritos = new System.Windows.Forms.DataGridView();
            this.F_eliminar = new FontAwesome.Sharp.IconButton();
            this.F_usuario = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.L_capitulo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_libro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.L_testamento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.L_version = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.L_idioma = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.L_versiculo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Favoritos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Favoritos
            // 
            this.DGV_Favoritos.AllowUserToAddRows = false;
            this.DGV_Favoritos.AllowUserToDeleteRows = false;
            this.DGV_Favoritos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Favoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Favoritos.Location = new System.Drawing.Point(23, 190);
            this.DGV_Favoritos.Name = "DGV_Favoritos";
            this.DGV_Favoritos.ReadOnly = true;
            this.DGV_Favoritos.Size = new System.Drawing.Size(455, 520);
            this.DGV_Favoritos.TabIndex = 53;
            this.DGV_Favoritos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Favoritos_CellContentClick);
            // 
            // F_eliminar
            // 
            this.F_eliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.F_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_eliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.F_eliminar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.F_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.F_eliminar.IconSize = 30;
            this.F_eliminar.Location = new System.Drawing.Point(604, 670);
            this.F_eliminar.Name = "F_eliminar";
            this.F_eliminar.Size = new System.Drawing.Size(104, 40);
            this.F_eliminar.TabIndex = 72;
            this.F_eliminar.Text = "Eliminar";
            this.F_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.F_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.F_eliminar.UseVisualStyleBackColor = false;
            this.F_eliminar.Click += new System.EventHandler(this.F_eliminar_Click);
            // 
            // F_usuario
            // 
            this.F_usuario.BackColor = System.Drawing.Color.Honeydew;
            this.F_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_usuario.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.F_usuario.IconColor = System.Drawing.Color.SeaGreen;
            this.F_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.F_usuario.IconSize = 30;
            this.F_usuario.Location = new System.Drawing.Point(487, 670);
            this.F_usuario.Name = "F_usuario";
            this.F_usuario.Size = new System.Drawing.Size(104, 40);
            this.F_usuario.TabIndex = 71;
            this.F_usuario.Text = "Agregar";
            this.F_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.F_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.F_usuario.UseVisualStyleBackColor = false;
            this.F_usuario.Click += new System.EventHandler(this.F_usuario_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Honeydew;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Chess;
            this.iconButton2.IconColor = System.Drawing.Color.SeaGreen;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(725, 118);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(221, 40);
            this.iconButton2.TabIndex = 91;
            this.iconButton2.Text = "Versiculos";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Chess;
            this.iconButton3.IconColor = System.Drawing.Color.Honeydew;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(487, 118);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(221, 40);
            this.iconButton3.TabIndex = 92;
            this.iconButton3.Text = "Capitulos";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(34, 105);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(427, 45);
            this.label25.TabIndex = 98;
            this.label25.Text = "Seleccione el tipo de favorito";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label26.Location = new System.Drawing.Point(20, 94);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(458, 64);
            this.label26.TabIndex = 97;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(494, 495);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 110;
            this.label19.Text = "Capitulo";
            // 
            // L_capitulo
            // 
            this.L_capitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_capitulo.Location = new System.Drawing.Point(494, 521);
            this.L_capitulo.Name = "L_capitulo";
            this.L_capitulo.Size = new System.Drawing.Size(198, 20);
            this.L_capitulo.TabIndex = 108;
            this.L_capitulo.Text = "versiculo";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label22.Location = new System.Drawing.Point(484, 486);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(224, 64);
            this.label22.TabIndex = 109;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(732, 200);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 17);
            this.label21.TabIndex = 105;
            this.label21.Text = "Versiculo";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(722, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(224, 520);
            this.label17.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Libro";
            // 
            // L_libro
            // 
            this.L_libro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_libro.Location = new System.Drawing.Point(494, 448);
            this.L_libro.Name = "L_libro";
            this.L_libro.Size = new System.Drawing.Size(198, 20);
            this.L_libro.TabIndex = 111;
            this.L_libro.Text = "versiculo";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(484, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 64);
            this.label5.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 116;
            this.label7.Text = "Testamento";
            // 
            // L_testamento
            // 
            this.L_testamento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_testamento.Location = new System.Drawing.Point(494, 375);
            this.L_testamento.Name = "L_testamento";
            this.L_testamento.Size = new System.Drawing.Size(198, 20);
            this.L_testamento.TabIndex = 114;
            this.L_testamento.Text = "versiculo";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(484, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 64);
            this.label9.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 119;
            this.label10.Text = "Version";
            // 
            // L_version
            // 
            this.L_version.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_version.Location = new System.Drawing.Point(494, 301);
            this.L_version.Name = "L_version";
            this.L_version.Size = new System.Drawing.Size(198, 20);
            this.L_version.TabIndex = 117;
            this.L_version.Text = "versiculo";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(484, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 64);
            this.label12.TabIndex = 118;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(494, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 122;
            this.label13.Text = "Idioma";
            // 
            // L_idioma
            // 
            this.L_idioma.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_idioma.Location = new System.Drawing.Point(494, 225);
            this.L_idioma.Name = "L_idioma";
            this.L_idioma.Size = new System.Drawing.Size(198, 20);
            this.L_idioma.TabIndex = 120;
            this.L_idioma.Text = "versiculo";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(484, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(224, 64);
            this.label15.TabIndex = 121;
            // 
            // L_versiculo
            // 
            this.L_versiculo.Location = new System.Drawing.Point(735, 220);
            this.L_versiculo.Multiline = true;
            this.L_versiculo.Name = "L_versiculo";
            this.L_versiculo.Size = new System.Drawing.Size(200, 473);
            this.L_versiculo.TabIndex = 123;
            // 
            // Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(958, 787);
            this.Controls.Add(this.L_versiculo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.L_idioma);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.L_version);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.L_testamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_libro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.L_capitulo);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.F_eliminar);
            this.Controls.Add(this.F_usuario);
            this.Controls.Add(this.DGV_Favoritos);
            this.Name = "Favoritos";
            this.Text = "favoritos";
            this.Load += new System.EventHandler(this.Favoritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Favoritos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Favoritos;
        private FontAwesome.Sharp.IconButton F_eliminar;
        private FontAwesome.Sharp.IconButton F_usuario;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label L_capitulo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_libro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label L_testamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label L_version;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label L_idioma;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox L_versiculo;
    }
}