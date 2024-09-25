namespace Practica_13
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
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.lblPromedioMayor = new System.Windows.Forms.Label();
            this.lblPromedioMenor = new System.Windows.Forms.Label();
            this.lblParcialesReprobados = new System.Windows.Forms.Label();
            this.lblDistribucion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(209, 22);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.RowHeadersWidth = 51;
            this.dataGridViewAlumnos.RowTemplate.Height = 24;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(648, 297);
            this.dataGridViewAlumnos.TabIndex = 0;
            this.dataGridViewAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlumnos_CellContentClick);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(484, 337);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // lblPromedioMayor
            // 
            this.lblPromedioMayor.AutoSize = true;
            this.lblPromedioMayor.Location = new System.Drawing.Point(183, 406);
            this.lblPromedioMayor.Name = "lblPromedioMayor";
            this.lblPromedioMayor.Size = new System.Drawing.Size(44, 16);
            this.lblPromedioMayor.TabIndex = 2;
            this.lblPromedioMayor.Text = "label1";
            // 
            // lblPromedioMenor
            // 
            this.lblPromedioMenor.AutoSize = true;
            this.lblPromedioMenor.Location = new System.Drawing.Point(183, 466);
            this.lblPromedioMenor.Name = "lblPromedioMenor";
            this.lblPromedioMenor.Size = new System.Drawing.Size(44, 16);
            this.lblPromedioMenor.TabIndex = 3;
            this.lblPromedioMenor.Text = "label1";
            // 
            // lblParcialesReprobados
            // 
            this.lblParcialesReprobados.AutoSize = true;
            this.lblParcialesReprobados.Location = new System.Drawing.Point(183, 518);
            this.lblParcialesReprobados.Name = "lblParcialesReprobados";
            this.lblParcialesReprobados.Size = new System.Drawing.Size(44, 16);
            this.lblParcialesReprobados.TabIndex = 4;
            this.lblParcialesReprobados.Text = "label1";
            // 
            // lblDistribucion
            // 
            this.lblDistribucion.AutoSize = true;
            this.lblDistribucion.Location = new System.Drawing.Point(632, 406);
            this.lblDistribucion.Name = "lblDistribucion";
            this.lblDistribucion.Size = new System.Drawing.Size(44, 16);
            this.lblDistribucion.TabIndex = 5;
            this.lblDistribucion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 560);
            this.Controls.Add(this.lblDistribucion);
            this.Controls.Add(this.lblParcialesReprobados);
            this.Controls.Add(this.lblPromedioMenor);
            this.Controls.Add(this.lblPromedioMayor);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label lblPromedioMayor;
        private System.Windows.Forms.Label lblPromedioMenor;
        private System.Windows.Forms.Label lblParcialesReprobados;
        private System.Windows.Forms.Label lblDistribucion;
    }
}

