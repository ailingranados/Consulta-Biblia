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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_historial)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_historial
            // 
            this.DGV_historial.AllowUserToAddRows = false;
            this.DGV_historial.AllowUserToDeleteRows = false;
            this.DGV_historial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_historial.Location = new System.Drawing.Point(25, 226);
            this.DGV_historial.Name = "DGV_historial";
            this.DGV_historial.ReadOnly = true;
            this.DGV_historial.Size = new System.Drawing.Size(890, 384);
            this.DGV_historial.TabIndex = 85;
            // 
            // rb_todo
            // 
            this.rb_todo.Location = new System.Drawing.Point(33, 165);
            this.rb_todo.Name = "rb_todo";
            this.rb_todo.Size = new System.Drawing.Size(119, 34);
            this.rb_todo.TabIndex = 108;
            this.rb_todo.TabStop = true;
            this.rb_todo.Text = "Seleccionar todo";
            this.rb_todo.UseVisualStyleBackColor = true;
            this.rb_todo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 111);
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
            this.BTN_eliminar.Location = new System.Drawing.Point(168, 165);
            this.BTN_eliminar.Name = "BTN_eliminar";
            this.BTN_eliminar.Size = new System.Drawing.Size(119, 34);
            this.BTN_eliminar.TabIndex = 111;
            this.BTN_eliminar.Text = "Eliminar ";
            this.BTN_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_eliminar.UseVisualStyleBackColor = false;
            this.BTN_eliminar.Click += new System.EventHandler(this.BTN_eliminar_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 34);
            this.label3.TabIndex = 116;
            this.label3.Text = "Para eliminar un registro seleccionelo o si desea eliminar todos los registros pu" +
    "lse el checkbox ";
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(960, 718);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_eliminar);
            this.Controls.Add(this.rb_todo);
            this.Controls.Add(this.DGV_historial);
            this.Controls.Add(this.label1);
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
    }
}