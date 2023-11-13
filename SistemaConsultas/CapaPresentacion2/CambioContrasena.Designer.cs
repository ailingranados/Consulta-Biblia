namespace CapaPresentacion2
{
    partial class CambioContrasena
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
            this.CC_con2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CC_con1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Aceptar = new FontAwesome.Sharp.IconButton();
            this.cancelar = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CC_con2
            // 
            this.CC_con2.BackColor = System.Drawing.Color.White;
            this.CC_con2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_con2.Location = new System.Drawing.Point(135, 189);
            this.CC_con2.Name = "CC_con2";
            this.CC_con2.Size = new System.Drawing.Size(248, 26);
            this.CC_con2.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(135, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Verifica tu contraseña";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(123, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 80);
            this.label10.TabIndex = 46;
            // 
            // CC_con1
            // 
            this.CC_con1.BackColor = System.Drawing.Color.White;
            this.CC_con1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_con1.Location = new System.Drawing.Point(135, 93);
            this.CC_con1.Name = "CC_con1";
            this.CC_con1.Size = new System.Drawing.Size(248, 26);
            this.CC_con1.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(135, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Contraseña nueva";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(123, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 80);
            this.label12.TabIndex = 43;
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.Pink;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.Aceptar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Aceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Aceptar.IconSize = 30;
            this.Aceptar.Location = new System.Drawing.Point(126, 260);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(126, 36);
            this.Aceptar.TabIndex = 55;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.cancelar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelar.IconSize = 30;
            this.cancelar.Location = new System.Drawing.Point(269, 260);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(126, 36);
            this.cancelar.TabIndex = 56;
            this.cancelar.Text = "Cancelar";
            this.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CambioContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(518, 349);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.CC_con2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CC_con1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Name = "CambioContrasena";
            this.Text = "CambioContrasena";
            this.Load += new System.EventHandler(this.CambioContrasena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CC_con2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CC_con1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton Aceptar;
        private FontAwesome.Sharp.IconButton cancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}