namespace CapaPresentacion2
{
    partial class Busqueda
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
            this.DGV_busqueda = new System.Windows.Forms.DataGridView();
            this.CB_version = new System.Windows.Forms.ComboBox();
            this.CB_idioma = new System.Windows.Forms.ComboBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_palabras = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_buscar = new FontAwesome.Sharp.IconButton();
            this.CB_libro = new System.Windows.Forms.ComboBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.CB_testamento = new System.Windows.Forms.ComboBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_busqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_busqueda
            // 
            this.DGV_busqueda.AllowUserToAddRows = false;
            this.DGV_busqueda.AllowUserToDeleteRows = false;
            this.DGV_busqueda.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_busqueda.Location = new System.Drawing.Point(322, 107);
            this.DGV_busqueda.Name = "DGV_busqueda";
            this.DGV_busqueda.ReadOnly = true;
            this.DGV_busqueda.Size = new System.Drawing.Size(565, 424);
            this.DGV_busqueda.TabIndex = 69;
            this.DGV_busqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_busqueda_CellContentClick);
            // 
            // CB_version
            // 
            this.CB_version.AllowDrop = true;
            this.CB_version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_version.FormattingEnabled = true;
            this.CB_version.Location = new System.Drawing.Point(63, 203);
            this.CB_version.Name = "CB_version";
            this.CB_version.Size = new System.Drawing.Size(216, 21);
            this.CB_version.TabIndex = 124;
            // 
            // CB_idioma
            // 
            this.CB_idioma.AllowDrop = true;
            this.CB_idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_idioma.FormattingEnabled = true;
            this.CB_idioma.Location = new System.Drawing.Point(63, 139);
            this.CB_idioma.Name = "CB_idioma";
            this.CB_idioma.Size = new System.Drawing.Size(216, 21);
            this.CB_idioma.TabIndex = 123;
            this.CB_idioma.SelectedIndexChanged += new System.EventHandler(this.CB_idioma_SelectedIndexChanged);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.LinesLeaning;
            this.iconPictureBox3.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 24;
            this.iconPictureBox3.Location = new System.Drawing.Point(31, 182);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox3.TabIndex = 122;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Language;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(31, 115);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox1.TabIndex = 121;
            this.iconPictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Version";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 119;
            this.label8.Text = "Idioma";
            // 
            // TB_palabras
            // 
            this.TB_palabras.BackColor = System.Drawing.Color.White;
            this.TB_palabras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_palabras.Location = new System.Drawing.Point(63, 414);
            this.TB_palabras.Name = "TB_palabras";
            this.TB_palabras.Size = new System.Drawing.Size(216, 26);
            this.TB_palabras.TabIndex = 107;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox2.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 24;
            this.iconPictureBox2.Location = new System.Drawing.Point(31, 394);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox2.TabIndex = 105;
            this.iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "Palabras a buscar";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 424);
            this.label2.TabIndex = 106;
            // 
            // BTN_buscar
            // 
            this.BTN_buscar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTN_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_buscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BTN_buscar.IconColor = System.Drawing.Color.White;
            this.BTN_buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_buscar.IconSize = 30;
            this.BTN_buscar.Location = new System.Drawing.Point(160, 481);
            this.BTN_buscar.Name = "BTN_buscar";
            this.BTN_buscar.Size = new System.Drawing.Size(119, 34);
            this.BTN_buscar.TabIndex = 125;
            this.BTN_buscar.Text = "Buscar";
            this.BTN_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_buscar.UseVisualStyleBackColor = false;
            this.BTN_buscar.Click += new System.EventHandler(this.BTN_buscar_Click);
            // 
            // CB_libro
            // 
            this.CB_libro.AllowDrop = true;
            this.CB_libro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_libro.FormattingEnabled = true;
            this.CB_libro.Location = new System.Drawing.Point(63, 324);
            this.CB_libro.Name = "CB_libro";
            this.CB_libro.Size = new System.Drawing.Size(216, 21);
            this.CB_libro.TabIndex = 132;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.iconPictureBox5.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 24;
            this.iconPictureBox5.Location = new System.Drawing.Point(32, 308);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(24, 26);
            this.iconPictureBox5.TabIndex = 131;
            this.iconPictureBox5.TabStop = false;
            // 
            // CB_testamento
            // 
            this.CB_testamento.AllowDrop = true;
            this.CB_testamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_testamento.FormattingEnabled = true;
            this.CB_testamento.Location = new System.Drawing.Point(63, 262);
            this.CB_testamento.Name = "CB_testamento";
            this.CB_testamento.Size = new System.Drawing.Size(216, 21);
            this.CB_testamento.TabIndex = 128;
            this.CB_testamento.SelectedIndexChanged += new System.EventHandler(this.CB_testamento_SelectedIndexChanged);
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox6.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconPictureBox6.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 23;
            this.iconPictureBox6.Location = new System.Drawing.Point(32, 246);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(23, 24);
            this.iconPictureBox6.TabIndex = 127;
            this.iconPictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 134;
            this.label6.Text = "Testamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "Libro";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(319, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(568, 111);
            this.label4.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 137;
            this.label5.Text = "Busqueda";
            // 
            // TB_busqueda
            // 
            this.TB_busqueda.Location = new System.Drawing.Point(332, 591);
            this.TB_busqueda.Multiline = true;
            this.TB_busqueda.Name = "TB_busqueda";
            this.TB_busqueda.Size = new System.Drawing.Size(536, 64);
            this.TB_busqueda.TabIndex = 139;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(919, 707);
            this.Controls.Add(this.TB_busqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_libro);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.CB_testamento);
            this.Controls.Add(this.iconPictureBox6);
            this.Controls.Add(this.BTN_buscar);
            this.Controls.Add(this.CB_version);
            this.Controls.Add(this.CB_idioma);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_palabras);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_busqueda);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_busqueda;
        private System.Windows.Forms.ComboBox CB_version;
        private System.Windows.Forms.ComboBox CB_idioma;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_palabras;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BTN_buscar;
        private System.Windows.Forms.ComboBox CB_libro;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.ComboBox CB_testamento;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_busqueda;
    }
}