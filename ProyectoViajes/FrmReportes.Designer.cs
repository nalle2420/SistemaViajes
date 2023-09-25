namespace ProyectoViajes
{
    partial class FrmReportes
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTransportista = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Viaje_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViajeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCalculado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegistrador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(873, 83);
            this.label5.TabIndex = 15;
            this.label5.Text = "Reporte de pago a transportistas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha Inicio";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Location = new System.Drawing.Point(107, 69);
            this.dtpFecha1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpFecha1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(171, 22);
            this.dtpFecha1.TabIndex = 20;
            this.dtpFecha1.Value = new System.DateTime(2023, 9, 25, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(377, 68);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 22);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2023, 9, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Transportista";
            // 
            // cmbTransportista
            // 
            this.cmbTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransportista.FormattingEnabled = true;
            this.cmbTransportista.Location = new System.Drawing.Point(668, 69);
            this.cmbTransportista.Name = "cmbTransportista";
            this.cmbTransportista.Size = new System.Drawing.Size(203, 24);
            this.cmbTransportista.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Viaje_ID,
            this.NombreCompleto,
            this.NombreSucursal,
            this.Fecha,
            this.ViajeTotal,
            this.TotalCalculado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 262);
            this.dataGridView1.TabIndex = 25;
            // 
            // Viaje_ID
            // 
            this.Viaje_ID.HeaderText = "ID";
            this.Viaje_ID.MinimumWidth = 6;
            this.Viaje_ID.Name = "Viaje_ID";
            this.Viaje_ID.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Empleado";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 170;
            // 
            // NombreSucursal
            // 
            this.NombreSucursal.HeaderText = "Sucursal";
            this.NombreSucursal.MinimumWidth = 6;
            this.NombreSucursal.Name = "NombreSucursal";
            this.NombreSucursal.ReadOnly = true;
            this.NombreSucursal.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // ViajeTotal
            // 
            this.ViajeTotal.HeaderText = "Distancia(KM)";
            this.ViajeTotal.MinimumWidth = 6;
            this.ViajeTotal.Name = "ViajeTotal";
            this.ViajeTotal.ReadOnly = true;
            this.ViajeTotal.Width = 125;
            // 
            // TotalCalculado
            // 
            this.TotalCalculado.HeaderText = "Total Viaje";
            this.TotalCalculado.MinimumWidth = 6;
            this.TotalCalculado.Name = "TotalCalculado";
            this.TotalCalculado.ReadOnly = true;
            this.TotalCalculado.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 34;
            this.label10.Text = "Total a pagar:";
            // 
            // txtRegistrador
            // 
            this.txtRegistrador.Location = new System.Drawing.Point(377, 394);
            this.txtRegistrador.Name = "txtRegistrador";
            this.txtRegistrador.ReadOnly = true;
            this.txtRegistrador.Size = new System.Drawing.Size(227, 22);
            this.txtRegistrador.TabIndex = 33;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(897, 432);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRegistrador);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbTransportista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpFecha1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTransportista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viaje_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViajeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCalculado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRegistrador;
    }
}