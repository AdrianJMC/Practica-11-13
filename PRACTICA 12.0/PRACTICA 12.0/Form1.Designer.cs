namespace PRACTICA_12._0
{
    partial class Form1
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
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMenorVenta = new System.Windows.Forms.Label();
            this.lblMayorVenta = new System.Windows.Forms.Label();
            this.lblVentaTotal = new System.Windows.Forms.Label();
            this.lblVentasPorDia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lunes,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Martes});
            this.dataGridViewVentas.Location = new System.Drawing.Point(209, 12);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.RowHeadersWidth = 51;
            this.dataGridViewVentas.RowTemplate.Height = 24;
            this.dataGridViewVentas.Size = new System.Drawing.Size(672, 405);
            this.dataGridViewVentas.TabIndex = 0;
            this.dataGridViewVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellContentClick);
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.MinimumWidth = 6;
            this.Lunes.Name = "Lunes";
            this.Lunes.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Martes";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Miercoles";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jueves";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Martes
            // 
            this.Martes.HeaderText = "Viernes";
            this.Martes.MinimumWidth = 6;
            this.Martes.Name = "Martes";
            this.Martes.Width = 125;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(489, 423);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMenorVenta
            // 
            this.lblMenorVenta.AutoSize = true;
            this.lblMenorVenta.Location = new System.Drawing.Point(206, 458);
            this.lblMenorVenta.Name = "lblMenorVenta";
            this.lblMenorVenta.Size = new System.Drawing.Size(44, 16);
            this.lblMenorVenta.TabIndex = 2;
            this.lblMenorVenta.Text = "label1";
            // 
            // lblMayorVenta
            // 
            this.lblMayorVenta.AutoSize = true;
            this.lblMayorVenta.Location = new System.Drawing.Point(206, 498);
            this.lblMayorVenta.Name = "lblMayorVenta";
            this.lblMayorVenta.Size = new System.Drawing.Size(44, 16);
            this.lblMayorVenta.TabIndex = 3;
            this.lblMayorVenta.Text = "label1";
            // 
            // lblVentaTotal
            // 
            this.lblVentaTotal.AutoSize = true;
            this.lblVentaTotal.Location = new System.Drawing.Point(206, 537);
            this.lblVentaTotal.Name = "lblVentaTotal";
            this.lblVentaTotal.Size = new System.Drawing.Size(44, 16);
            this.lblVentaTotal.TabIndex = 4;
            this.lblVentaTotal.Text = "label1";
            // 
            // lblVentasPorDia
            // 
            this.lblVentasPorDia.AutoSize = true;
            this.lblVentasPorDia.Location = new System.Drawing.Point(666, 458);
            this.lblVentasPorDia.Name = "lblVentasPorDia";
            this.lblVentasPorDia.Size = new System.Drawing.Size(44, 16);
            this.lblVentasPorDia.TabIndex = 5;
            this.lblVentasPorDia.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 573);
            this.Controls.Add(this.lblVentasPorDia);
            this.Controls.Add(this.lblVentaTotal);
            this.Controls.Add(this.lblMayorVenta);
            this.Controls.Add(this.lblMenorVenta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dataGridViewVentas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMenorVenta;
        private System.Windows.Forms.Label lblMayorVenta;
        private System.Windows.Forms.Label lblVentaTotal;
        private System.Windows.Forms.Label lblVentasPorDia;
    }
}

