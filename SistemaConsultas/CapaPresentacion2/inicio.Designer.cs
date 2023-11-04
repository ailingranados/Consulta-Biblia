namespace CapaPresentacion2
{
    partial class inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.menuFavorito = new FontAwesome.Sharp.IconMenuItem();
            this.menuHistorial = new FontAwesome.Sharp.IconMenuItem();
            this.menuConsulta = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuFavorito,
            this.menuHistorial,
            this.menuConsulta,
            this.iconMenuItem2,
            this.menuAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 64);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(857, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            this.menuUsuario.AutoSize = false;
            this.menuUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuUsuario.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.menuUsuario.IconColor = System.Drawing.Color.RosyBrown;
            this.menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuario.IconSize = 50;
            this.menuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(122, 69);
            this.menuUsuario.Text = "Usuario";
            this.menuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuFavorito
            // 
            this.menuFavorito.AutoSize = false;
            this.menuFavorito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuFavorito.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.menuFavorito.IconColor = System.Drawing.Color.RosyBrown;
            this.menuFavorito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuFavorito.IconSize = 50;
            this.menuFavorito.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFavorito.Name = "menuFavorito";
            this.menuFavorito.Size = new System.Drawing.Size(122, 69);
            this.menuFavorito.Text = "Favoritos";
            this.menuFavorito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuHistorial
            // 
            this.menuHistorial.AutoSize = false;
            this.menuHistorial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuHistorial.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.menuHistorial.IconColor = System.Drawing.Color.RosyBrown;
            this.menuHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuHistorial.IconSize = 50;
            this.menuHistorial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuHistorial.Name = "menuHistorial";
            this.menuHistorial.Size = new System.Drawing.Size(122, 69);
            this.menuHistorial.Text = "Historial";
            this.menuHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuConsulta
            // 
            this.menuConsulta.AutoSize = false;
            this.menuConsulta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuConsulta.IconChar = FontAwesome.Sharp.IconChar.Glasses;
            this.menuConsulta.IconColor = System.Drawing.Color.RosyBrown;
            this.menuConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuConsulta.IconSize = 50;
            this.menuConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(122, 69);
            this.menuConsulta.Text = "Consulta";
            this.menuConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.AutoSize = false;
            this.menuAcercaDe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menuAcercaDe.IconColor = System.Drawing.Color.RosyBrown;
            this.menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercaDe.IconSize = 50;
            this.menuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(122, 69);
            this.menuAcercaDe.Text = "Acerca de";
            this.menuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.RosyBrown;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(857, 64);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Biblioteca";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 499);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconMenuItem2.IconColor = System.Drawing.Color.RosyBrown;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 50;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem2.Text = "Busqueda";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 563);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuFavorito;
        private FontAwesome.Sharp.IconMenuItem menuHistorial;
        private FontAwesome.Sharp.IconMenuItem menuConsulta;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}

