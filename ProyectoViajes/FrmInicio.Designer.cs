namespace ProyectoViajes
{
    partial class FrmInicio
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
            this.menuNav = new System.Windows.Forms.MenuStrip();
            this.MenuEmpleado = new FontAwesome.Sharp.IconMenuItem();
            this.MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAdmin = new FontAwesome.Sharp.IconMenuItem();
            this.MenuRegistro = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTransportista = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReporte = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.menuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNav
            // 
            this.menuNav.BackColor = System.Drawing.Color.White;
            this.menuNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEmpleado,
            this.MenuUsuario,
            this.MenuAdmin,
            this.MenuRegistro,
            this.MenuTransportista,
            this.MenuReporte});
            this.menuNav.Location = new System.Drawing.Point(0, 54);
            this.menuNav.Name = "menuNav";
            this.menuNav.Size = new System.Drawing.Size(938, 68);
            this.menuNav.TabIndex = 0;
            this.menuNav.Text = "menuStrip1";
            // 
            // MenuEmpleado
            // 
            this.MenuEmpleado.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.MenuEmpleado.IconColor = System.Drawing.Color.Black;
            this.MenuEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuEmpleado.IconSize = 40;
            this.MenuEmpleado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuEmpleado.Name = "MenuEmpleado";
            this.MenuEmpleado.Size = new System.Drawing.Size(97, 64);
            this.MenuEmpleado.Text = "Empleados";
            this.MenuEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuUsuario.IconColor = System.Drawing.Color.Black;
            this.MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuario.IconSize = 40;
            this.MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(79, 64);
            this.MenuUsuario.Text = "Usuarios";
            this.MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuario.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // MenuAdmin
            // 
            this.MenuAdmin.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.MenuAdmin.IconColor = System.Drawing.Color.Black;
            this.MenuAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAdmin.IconSize = 40;
            this.MenuAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.Size = new System.Drawing.Size(125, 64);
            this.MenuAdmin.Text = "Admin Sucursal";
            this.MenuAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuRegistro
            // 
            this.MenuRegistro.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.MenuRegistro.IconColor = System.Drawing.Color.Black;
            this.MenuRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuRegistro.IconSize = 40;
            this.MenuRegistro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuRegistro.Name = "MenuRegistro";
            this.MenuRegistro.Size = new System.Drawing.Size(121, 64);
            this.MenuRegistro.Text = "Registro Viajes";
            this.MenuRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuTransportista
            // 
            this.MenuTransportista.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.MenuTransportista.IconColor = System.Drawing.Color.Black;
            this.MenuTransportista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuTransportista.IconSize = 40;
            this.MenuTransportista.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuTransportista.Name = "MenuTransportista";
            this.MenuTransportista.Size = new System.Drawing.Size(114, 64);
            this.MenuTransportista.Text = "Transportistas";
            this.MenuTransportista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuReporte
            // 
            this.MenuReporte.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.MenuReporte.IconColor = System.Drawing.Color.Black;
            this.MenuReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReporte.IconSize = 40;
            this.MenuReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReporte.Name = "MenuReporte";
            this.MenuReporte.Size = new System.Drawing.Size(82, 64);
            this.MenuReporte.Text = "Reportes";
            this.MenuReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuReporte.Click += new System.EventHandler(this.MenuReporta_Click);
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(938, 54);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Viajes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 122);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(938, 398);
            this.Contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(753, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bienvenido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblNombre.Location = new System.Drawing.Point(753, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 25);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "lblNombre";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuNav);
            this.Controls.Add(this.MenuTitulo);
            this.MainMenuStrip = this.menuNav;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.menuNav.ResumeLayout(false);
            this.menuNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuNav;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuEmpleado;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuAdmin;
        private FontAwesome.Sharp.IconMenuItem MenuRegistro;
        private FontAwesome.Sharp.IconMenuItem MenuTransportista;
        private FontAwesome.Sharp.IconMenuItem MenuReporte;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
    }
}