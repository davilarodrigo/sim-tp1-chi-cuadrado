namespace WindowsFormsApp1
{
    partial class FrmGeneradorPseudoAleatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneradorPseudoAleatorio));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorRaiz = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnGenerarNuevaLista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMultiplicativo = new System.Windows.Forms.RadioButton();
            this.radioLineal = new System.Windows.Forms.RadioButton();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.txtLongitudLista = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioKyG = new System.Windows.Forms.RadioButton();
            this.radioAyM = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblIteracion = new System.Windows.Forms.Label();
            this.btnGenerarAdicional = new System.Windows.Forms.Button();
            this.dataGridViewValoresLista = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAnalisiChi = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonExportarExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoresLista)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(15, 219);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(165, 27);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar secuencia";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Raíz";
            // 
            // txtValorRaiz
            // 
            this.txtValorRaiz.Location = new System.Drawing.Point(61, 6);
            this.txtValorRaiz.Name = "txtValorRaiz";
            this.txtValorRaiz.Size = new System.Drawing.Size(111, 20);
            this.txtValorRaiz.TabIndex = 0;
            this.txtValorRaiz.TextChanged += new System.EventHandler(this.txtParam1_TextChanged);
            this.txtValorRaiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParam1_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNumero.Location = new System.Drawing.Point(17, 342);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(169, 24);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número Generado";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerarNuevaLista
            // 
            this.btnGenerarNuevaLista.Location = new System.Drawing.Point(15, 248);
            this.btnGenerarNuevaLista.Name = "btnGenerarNuevaLista";
            this.btnGenerarNuevaLista.Size = new System.Drawing.Size(165, 27);
            this.btnGenerarNuevaLista.TabIndex = 4;
            this.btnGenerarNuevaLista.Text = "Generar Nueva Lista";
            this.btnGenerarNuevaLista.UseVisualStyleBackColor = true;
            this.btnGenerarNuevaLista.Click += new System.EventHandler(this.btnGenerarNuevaLista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Raíz Utilizada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor K";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor G";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(224, 6);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(110, 20);
            this.txtC.TabIndex = 1;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(61, 32);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(110, 20);
            this.txtK.TabIndex = 2;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            this.txtK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK_KeyPress);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(61, 58);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(110, 20);
            this.txtG.TabIndex = 3;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtG_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMultiplicativo);
            this.groupBox1.Controls.Add(this.radioLineal);
            this.groupBox1.Location = new System.Drawing.Point(8, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo Congruente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioMultiplicativo
            // 
            this.radioMultiplicativo.AutoSize = true;
            this.radioMultiplicativo.Location = new System.Drawing.Point(13, 42);
            this.radioMultiplicativo.Name = "radioMultiplicativo";
            this.radioMultiplicativo.Size = new System.Drawing.Size(86, 17);
            this.radioMultiplicativo.TabIndex = 1;
            this.radioMultiplicativo.Text = "Multiplicativo";
            this.radioMultiplicativo.UseVisualStyleBackColor = true;
            this.radioMultiplicativo.CheckedChanged += new System.EventHandler(this.radioMultiplicativo_CheckedChanged);
            // 
            // radioLineal
            // 
            this.radioLineal.AutoSize = true;
            this.radioLineal.Checked = true;
            this.radioLineal.Location = new System.Drawing.Point(13, 19);
            this.radioLineal.Name = "radioLineal";
            this.radioLineal.Size = new System.Drawing.Size(89, 17);
            this.radioLineal.TabIndex = 0;
            this.radioLineal.TabStop = true;
            this.radioLineal.Text = "Lineal o mixto";
            this.radioLineal.UseVisualStyleBackColor = true;
            this.radioLineal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(12, 316);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(46, 13);
            this.lblMetodo.TabIndex = 6;
            this.lblMetodo.Text = "Metodo:";
            this.lblMetodo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMetodo.Click += new System.EventHandler(this.lblMetodo_Click);
            // 
            // txtLongitudLista
            // 
            this.txtLongitudLista.Location = new System.Drawing.Point(13, 19);
            this.txtLongitudLista.Name = "txtLongitudLista";
            this.txtLongitudLista.Size = new System.Drawing.Size(310, 20);
            this.txtLongitudLista.TabIndex = 0;
            this.txtLongitudLista.TextChanged += new System.EventHandler(this.txtLongitudLista_TextChanged);
            this.txtLongitudLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLongitudLista_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioKyG);
            this.groupBox2.Controls.Add(this.radioAyM);
            this.groupBox2.Location = new System.Drawing.Point(189, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 69);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elegir tipo de Parámetro";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioKyG
            // 
            this.radioKyG.AutoSize = true;
            this.radioKyG.Checked = true;
            this.radioKyG.Location = new System.Drawing.Point(13, 42);
            this.radioKyG.Name = "radioKyG";
            this.radioKyG.Size = new System.Drawing.Size(51, 17);
            this.radioKyG.TabIndex = 1;
            this.radioKyG.TabStop = true;
            this.radioKyG.Text = "K y G";
            this.radioKyG.UseVisualStyleBackColor = true;
            this.radioKyG.CheckedChanged += new System.EventHandler(this.radioKyG_CheckedChanged);
            // 
            // radioAyM
            // 
            this.radioAyM.AutoSize = true;
            this.radioAyM.Location = new System.Drawing.Point(13, 19);
            this.radioAyM.Name = "radioAyM";
            this.radioAyM.Size = new System.Drawing.Size(52, 17);
            this.radioAyM.TabIndex = 0;
            this.radioAyM.Text = "A y M";
            this.radioAyM.UseVisualStyleBackColor = true;
            this.radioAyM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Valor M";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Valor A";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(224, 32);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(110, 20);
            this.txtM.TabIndex = 4;
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(224, 58);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(110, 20);
            this.txtA.TabIndex = 5;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // lblIteracion
            // 
            this.lblIteracion.AutoSize = true;
            this.lblIteracion.Location = new System.Drawing.Point(184, 293);
            this.lblIteracion.Name = "lblIteracion";
            this.lblIteracion.Size = new System.Drawing.Size(51, 13);
            this.lblIteracion.TabIndex = 6;
            this.lblIteracion.Text = "Iteración:";
            // 
            // btnGenerarAdicional
            // 
            this.btnGenerarAdicional.Enabled = false;
            this.btnGenerarAdicional.Location = new System.Drawing.Point(189, 219);
            this.btnGenerarAdicional.Name = "btnGenerarAdicional";
            this.btnGenerarAdicional.Size = new System.Drawing.Size(153, 27);
            this.btnGenerarAdicional.TabIndex = 3;
            this.btnGenerarAdicional.Text = "Generar Número Adicional";
            this.btnGenerarAdicional.UseVisualStyleBackColor = true;
            this.btnGenerarAdicional.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dataGridViewValoresLista
            // 
            this.dataGridViewValoresLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValoresLista.Location = new System.Drawing.Point(354, 12);
            this.dataGridViewValoresLista.Name = "dataGridViewValoresLista";
            this.dataGridViewValoresLista.Size = new System.Drawing.Size(248, 395);
            this.dataGridViewValoresLista.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLongitudLista);
            this.groupBox3.Location = new System.Drawing.Point(8, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 48);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad de números a generar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtA);
            this.groupBox4.Controls.Add(this.txtM);
            this.groupBox4.Controls.Add(this.txtG);
            this.groupBox4.Controls.Add(this.txtK);
            this.groupBox4.Controls.Add(this.txtC);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtValorRaiz);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 84);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // btnAnalisiChi
            // 
            this.btnAnalisiChi.Enabled = false;
            this.btnAnalisiChi.Location = new System.Drawing.Point(15, 380);
            this.btnAnalisiChi.Name = "btnAnalisiChi";
            this.btnAnalisiChi.Size = new System.Drawing.Size(146, 27);
            this.btnAnalisiChi.TabIndex = 5;
            this.btnAnalisiChi.Text = "Análisis de Chi Cuadrado";
            this.btnAnalisiChi.UseVisualStyleBackColor = true;
            this.btnAnalisiChi.Click += new System.EventHandler(this.btnAnalisiChi_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(291, 380);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(57, 27);
            this.buttonVolver.TabIndex = 8;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonExportarExcel
            // 
            this.buttonExportarExcel.Location = new System.Drawing.Point(167, 380);
            this.buttonExportarExcel.Name = "buttonExportarExcel";
            this.buttonExportarExcel.Size = new System.Drawing.Size(118, 27);
            this.buttonExportarExcel.TabIndex = 6;
            this.buttonExportarExcel.Text = "Exportar a Excel";
            this.buttonExportarExcel.UseVisualStyleBackColor = true;
            this.buttonExportarExcel.Click += new System.EventHandler(this.buttonExportarExcel_Click);
            // 
            // FrmGeneradorPseudoAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 419);
            this.Controls.Add(this.buttonExportarExcel);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.btnAnalisiChi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewValoresLista);
            this.Controls.Add(this.btnGenerarAdicional);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIteracion);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerarNuevaLista);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnGenerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(630, 458);
            this.Name = "FrmGeneradorPseudoAleatorio";
            this.Text = "Generador de Números Pseudoaleatórios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoresLista)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorRaiz;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnGenerarNuevaLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMultiplicativo;
        private System.Windows.Forms.RadioButton radioLineal;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.TextBox txtLongitudLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioKyG;
        private System.Windows.Forms.RadioButton radioAyM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblIteracion;
        private System.Windows.Forms.Button btnGenerarAdicional;
        private System.Windows.Forms.DataGridView dataGridViewValoresLista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAnalisiChi;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonExportarExcel;
    }
}

