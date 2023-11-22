namespace CapaPresentacion2
{
    partial class Pregunta_secreta
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
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_ingresar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NACIMIENTO = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconPictureBox2.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 34;
            this.iconPictureBox2.Location = new System.Drawing.Point(241, 83);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(34, 36);
            this.iconPictureBox2.TabIndex = 22;
            this.iconPictureBox2.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelar.IconSize = 21;
            this.btn_cancelar.Location = new System.Drawing.Point(393, 178);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 30);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_ingresar.IconColor = System.Drawing.Color.Black;
            this.btn_ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ingresar.IconSize = 21;
            this.btn_ingresar.Location = new System.Drawing.Point(241, 178);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(120, 30);
            this.btn_ingresar.TabIndex = 20;
            this.btn_ingresar.Text = "Aceptar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "¿Cual es su fecha de nacimiento?";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BookBible;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 139;
            this.iconPictureBox1.Location = new System.Drawing.Point(23, 31);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(158, 139);
            this.iconPictureBox1.TabIndex = 15;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "BIBLIOTECA";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 273);
            this.label1.TabIndex = 13;
            // 
            // NACIMIENTO
            // 
            this.NACIMIENTO.CustomFormat = "yyyy.MM.dd";
            this.NACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NACIMIENTO.Location = new System.Drawing.Point(285, 99);
            this.NACIMIENTO.MaxDate = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            this.NACIMIENTO.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.NACIMIENTO.Name = "NACIMIENTO";
            this.NACIMIENTO.Size = new System.Drawing.Size(219, 20);
            this.NACIMIENTO.TabIndex = 48;
            this.NACIMIENTO.Value = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            // 
            // Pregunta_secreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 273);
            this.ControlBox = false;
            this.Controls.Add(this.NACIMIENTO);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta_secreta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta secreta";
            this.Load += new System.EventHandler(this.Pregunta_secreta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private FontAwesome.Sharp.IconButton btn_ingresar;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker NACIMIENTO;
    }
}