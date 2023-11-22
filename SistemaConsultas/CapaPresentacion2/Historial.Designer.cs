namespace CapaPresentacion2
{
    partial class Historial
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
            this.DGV_historial = new System.Windows.Forms.DataGridView();
            this.rb_todo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_eliminar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_consultas = new FontAwesome.Sharp.IconButton();
            this.BTN_busquedas = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_historial)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_historial
            // 
            this.DGV_historial.AllowUserToAddRows = false;
            this.DGV_historial.AllowUserToDeleteRows = false;
            this.DGV_historial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_historial.Location = new System.Drawing.Point(36, 222);
            this.DGV_historial.Name = "DGV_historial";
            this.DGV_historial.ReadOnly = true;
            this.DGV_historial.Size = new System.Drawing.Size(890, 393);
            this.DGV_historial.TabIndex = 85;
            // 
            // rb_todo
            // 
            this.rb_todo.Location = new System.Drawing.Point(47, 161);
            this.rb_todo.Name = "rb_todo";
            this.rb_todo.Size = new System.Drawing.Size(159, 38);
            this.rb_todo.TabIndex = 108;
            this.rb_todo.TabStop = true;
            this.rb_todo.Text = "Seleccionar todo";
            this.rb_todo.UseVisualStyleBackColor = true;
            this.rb_todo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(36, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 111);
            this.label1.TabIndex = 110;
            // 
            // BTN_eliminar
            // 
            this.BTN_eliminar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTN_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_eliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BTN_eliminar.IconColor = System.Drawing.Color.White;
            this.BTN_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_eliminar.IconSize = 30;
            this.BTN_eliminar.Location = new System.Drawing.Point(225, 161);
            this.BTN_eliminar.Name = "BTN_eliminar";
            this.BTN_eliminar.Size = new System.Drawing.Size(159, 38);
            this.BTN_eliminar.TabIndex = 111;
            this.BTN_eliminar.Text = "Eliminar ";
            this.BTN_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_eliminar.UseVisualStyleBackColor = false;
            this.BTN_eliminar.Click += new System.EventHandler(this.BTN_eliminar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 34);
            this.label3.TabIndex = 116;
            this.label3.Text = "Para eliminar un registro seleccionelo o si desea eliminar todos los registros pu" +
    "lse el checkbox ";
            // 
            // BTN_consultas
            // 
            this.BTN_consultas.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_consultas.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.BTN_consultas.IconColor = System.Drawing.Color.Honeydew;
            this.BTN_consultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_consultas.IconSize = 30;
            this.BTN_consultas.Location = new System.Drawing.Point(448, 161);
            this.BTN_consultas.Name = "BTN_consultas";
            this.BTN_consultas.Size = new System.Drawing.Size(221, 40);
            this.BTN_consultas.TabIndex = 118;
            this.BTN_consultas.Text = "Consultas";
            this.BTN_consultas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_consultas.UseVisualStyleBackColor = false;
            this.BTN_consultas.Click += new System.EventHandler(this.BTN_consultas_Click);
            // 
            // BTN_busquedas
            // 
            this.BTN_busquedas.BackColor = System.Drawing.Color.Honeydew;
            this.BTN_busquedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_busquedas.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.BTN_busquedas.IconColor = System.Drawing.Color.SeaGreen;
            this.BTN_busquedas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_busquedas.IconSize = 30;
            this.BTN_busquedas.Location = new System.Drawing.Point(682, 161);
            this.BTN_busquedas.Name = "BTN_busquedas";
            this.BTN_busquedas.Size = new System.Drawing.Size(221, 40);
            this.BTN_busquedas.TabIndex = 117;
            this.BTN_busquedas.Text = "Busquedas";
            this.BTN_busquedas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_busquedas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_busquedas.UseVisualStyleBackColor = false;
            this.BTN_busquedas.Click += new System.EventHandler(this.BTN_busquedas_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 34);
            this.label2.TabIndex = 120;
            this.label2.Text = "Elegir el tipo de historial a consultar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(420, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(506, 111);
            this.label4.TabIndex = 119;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(960, 718);
            this.Controls.Add(this.BTN_consultas);
            this.Controls.Add(this.BTN_busquedas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_eliminar);
            this.Controls.Add(this.rb_todo);
            this.Controls.Add(this.DGV_historial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_historial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_historial;
        private System.Windows.Forms.RadioButton rb_todo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BTN_eliminar;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton BTN_consultas;
        private FontAwesome.Sharp.IconButton BTN_busquedas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}