namespace WindowsFormsApp1
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.dgvFrecuencia = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnTestChiCuadrado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 38);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(146, 400);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(12, 12);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(260, 20);
            this.txtLista.TabIndex = 1;
            this.txtLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLista_KeyDown);
            this.txtLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLista_KeyPress);
            // 
            // dgvFrecuencia
            // 
            this.dgvFrecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencia.Location = new System.Drawing.Point(164, 38);
            this.dgvFrecuencia.Name = "dgvFrecuencia";
            this.dgvFrecuencia.Size = new System.Drawing.Size(270, 400);
            this.dgvFrecuencia.TabIndex = 0;
            this.dgvFrecuencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(278, 10);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnTestChiCuadrado
            // 
            this.btnTestChiCuadrado.Location = new System.Drawing.Point(359, 10);
            this.btnTestChiCuadrado.Name = "btnTestChiCuadrado";
            this.btnTestChiCuadrado.Size = new System.Drawing.Size(75, 23);
            this.btnTestChiCuadrado.TabIndex = 2;
            this.btnTestChiCuadrado.Text = "Test";
            this.btnTestChiCuadrado.UseVisualStyleBackColor = true;
            this.btnTestChiCuadrado.Click += new System.EventHandler(this.btnTestChi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestChiCuadrado);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.dgvFrecuencia);
            this.Controls.Add(this.dgvLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.DataGridView dgvFrecuencia;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnTestChiCuadrado;
    }
}

