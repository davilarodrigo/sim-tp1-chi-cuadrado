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
            this.btnTestChiCuadrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.rdbAutomatico = new System.Windows.Forms.RadioButton();
            this.txtCantidadIntervalos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGenerarNumerosAleatorios = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(232, 12);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(146, 299);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(239, 319);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(231, 20);
            this.txtLista.TabIndex = 1;
            this.txtLista.TextChanged += new System.EventHandler(this.txtLista_TextChanged);
            this.txtLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLista_KeyDown);
            this.txtLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLista_KeyPress);
            // 
            // dgvFrecuencia
            // 
            this.dgvFrecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencia.Location = new System.Drawing.Point(384, 12);
            this.dgvFrecuencia.Name = "dgvFrecuencia";
            this.dgvFrecuencia.Size = new System.Drawing.Size(404, 299);
            this.dgvFrecuencia.TabIndex = 0;
            this.dgvFrecuencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTestChiCuadrado
            // 
            this.btnTestChiCuadrado.Location = new System.Drawing.Point(476, 317);
            this.btnTestChiCuadrado.Name = "btnTestChiCuadrado";
            this.btnTestChiCuadrado.Size = new System.Drawing.Size(75, 23);
            this.btnTestChiCuadrado.TabIndex = 2;
            this.btnTestChiCuadrado.Text = "Test";
            this.btnTestChiCuadrado.UseVisualStyleBackColor = true;
            this.btnTestChiCuadrado.Click += new System.EventHandler(this.btnTestChi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chi Cuadrado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidadIntervalos);
            this.groupBox1.Controls.Add(this.rdbAutomatico);
            this.groupBox1.Controls.Add(this.rdbManual);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 103);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de Intervalos";
            // 
            // rdbManual
            // 
            this.rdbManual.AutoSize = true;
            this.rdbManual.Location = new System.Drawing.Point(24, 49);
            this.rdbManual.Name = "rdbManual";
            this.rdbManual.Size = new System.Drawing.Size(122, 17);
            this.rdbManual.TabIndex = 0;
            this.rdbManual.Text = "Definir Manualmente";
            this.rdbManual.UseVisualStyleBackColor = true;
            this.rdbManual.CheckedChanged += new System.EventHandler(this.rdbManual_CheckedChanged);
            // 
            // rdbAutomatico
            // 
            this.rdbAutomatico.AutoSize = true;
            this.rdbAutomatico.Checked = true;
            this.rdbAutomatico.Location = new System.Drawing.Point(24, 26);
            this.rdbAutomatico.Name = "rdbAutomatico";
            this.rdbAutomatico.Size = new System.Drawing.Size(140, 17);
            this.rdbAutomatico.TabIndex = 0;
            this.rdbAutomatico.TabStop = true;
            this.rdbAutomatico.Text = "Definir Automaticamente";
            this.rdbAutomatico.UseVisualStyleBackColor = true;
            this.rdbAutomatico.CheckedChanged += new System.EventHandler(this.rdbAutomatico_CheckedChanged);
            // 
            // txtCantidadIntervalos
            // 
            this.txtCantidadIntervalos.Enabled = false;
            this.txtCantidadIntervalos.Location = new System.Drawing.Point(113, 69);
            this.txtCantidadIntervalos.Name = "txtCantidadIntervalos";
            this.txtCantidadIntervalos.Size = new System.Drawing.Size(95, 20);
            this.txtCantidadIntervalos.TabIndex = 1;
            this.txtCantidadIntervalos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadIntervalos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantida a Utilizar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerarNumerosAleatorios);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar Lista de Numeros Aleatorios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad a Generar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btnGenerarNumerosAleatorios
            // 
            this.btnGenerarNumerosAleatorios.Location = new System.Drawing.Point(108, 57);
            this.btnGenerarNumerosAleatorios.Name = "btnGenerarNumerosAleatorios";
            this.btnGenerarNumerosAleatorios.Size = new System.Drawing.Size(100, 23);
            this.btnGenerarNumerosAleatorios.TabIndex = 2;
            this.btnGenerarNumerosAleatorios.Text = "Generar";
            this.btnGenerarNumerosAleatorios.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generar Grafico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestChiCuadrado);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.dgvFrecuencia);
            this.Controls.Add(this.dgvLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.DataGridView dgvFrecuencia;
        private System.Windows.Forms.Button btnTestChiCuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidadIntervalos;
        private System.Windows.Forms.RadioButton rdbAutomatico;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerarNumerosAleatorios;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

