﻿namespace WindowsFormsApp1
{
    partial class FrmAnalisisChiCuadrado
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
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.dgvFrecuencia = new System.Windows.Forms.DataGridView();
            this.btnTestChiCuadrado = new System.Windows.Forms.Button();
            this.lblChiCuadrado = new System.Windows.Forms.Label();
            this.grpIntervalos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadIntervalos = new System.Windows.Forms.TextBox();
            this.rdbAutomatico = new System.Windows.Forms.RadioButton();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.grpGeneradorMuestra = new System.Windows.Forms.GroupBox();
            this.btnGenerarNumerosAleatorios = new System.Windows.Forms.Button();
            this.txtTamañoMuestraAGenerar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.grpAgregarValor = new System.Windows.Forms.GroupBox();
            this.lblTamañoMuestra = new System.Windows.Forms.Label();
            this.btnEliminarMuestra = new System.Windows.Forms.Button();
            this.txtDecimales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).BeginInit();
            this.grpIntervalos.SuspendLayout();
            this.grpGeneradorMuestra.SuspendLayout();
            this.grpAgregarValor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(232, 12);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.Size = new System.Drawing.Size(146, 299);
            this.dgvMuestra.TabIndex = 0;
            this.dgvMuestra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(6, 19);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(202, 20);
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
            this.btnTestChiCuadrado.Location = new System.Drawing.Point(232, 317);
            this.btnTestChiCuadrado.Name = "btnTestChiCuadrado";
            this.btnTestChiCuadrado.Size = new System.Drawing.Size(146, 23);
            this.btnTestChiCuadrado.TabIndex = 2;
            this.btnTestChiCuadrado.Text = "Analizar Muestra";
            this.btnTestChiCuadrado.UseVisualStyleBackColor = true;
            this.btnTestChiCuadrado.Click += new System.EventHandler(this.btnTestChi_Click);
            // 
            // lblChiCuadrado
            // 
            this.lblChiCuadrado.AutoSize = true;
            this.lblChiCuadrado.Location = new System.Drawing.Point(557, 322);
            this.lblChiCuadrado.Name = "lblChiCuadrado";
            this.lblChiCuadrado.Size = new System.Drawing.Size(71, 13);
            this.lblChiCuadrado.TabIndex = 4;
            this.lblChiCuadrado.Text = "Chi Cuadrado";
            // 
            // grpIntervalos
            // 
            this.grpIntervalos.Controls.Add(this.label2);
            this.grpIntervalos.Controls.Add(this.txtCantidadIntervalos);
            this.grpIntervalos.Controls.Add(this.rdbAutomatico);
            this.grpIntervalos.Controls.Add(this.rdbManual);
            this.grpIntervalos.Location = new System.Drawing.Point(12, 12);
            this.grpIntervalos.Name = "grpIntervalos";
            this.grpIntervalos.Size = new System.Drawing.Size(214, 103);
            this.grpIntervalos.TabIndex = 5;
            this.grpIntervalos.TabStop = false;
            this.grpIntervalos.Text = "Cantidad de Intervalos";
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
            // txtCantidadIntervalos
            // 
            this.txtCantidadIntervalos.Enabled = false;
            this.txtCantidadIntervalos.Location = new System.Drawing.Point(108, 69);
            this.txtCantidadIntervalos.Name = "txtCantidadIntervalos";
            this.txtCantidadIntervalos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadIntervalos.TabIndex = 1;
            this.txtCantidadIntervalos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadIntervalos_KeyPress);
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
            // grpGeneradorMuestra
            // 
            this.grpGeneradorMuestra.Controls.Add(this.btnEliminarMuestra);
            this.grpGeneradorMuestra.Controls.Add(this.btnGenerarNumerosAleatorios);
            this.grpGeneradorMuestra.Controls.Add(this.txtDecimales);
            this.grpGeneradorMuestra.Controls.Add(this.txtTamañoMuestraAGenerar);
            this.grpGeneradorMuestra.Controls.Add(this.label1);
            this.grpGeneradorMuestra.Controls.Add(this.label3);
            this.grpGeneradorMuestra.Location = new System.Drawing.Point(12, 121);
            this.grpGeneradorMuestra.Name = "grpGeneradorMuestra";
            this.grpGeneradorMuestra.Size = new System.Drawing.Size(214, 112);
            this.grpGeneradorMuestra.TabIndex = 6;
            this.grpGeneradorMuestra.TabStop = false;
            this.grpGeneradorMuestra.Text = "Generar Muestra de Numeros Aleatorios";
            // 
            // btnGenerarNumerosAleatorios
            // 
            this.btnGenerarNumerosAleatorios.Location = new System.Drawing.Point(108, 81);
            this.btnGenerarNumerosAleatorios.Name = "btnGenerarNumerosAleatorios";
            this.btnGenerarNumerosAleatorios.Size = new System.Drawing.Size(100, 23);
            this.btnGenerarNumerosAleatorios.TabIndex = 2;
            this.btnGenerarNumerosAleatorios.Text = "Generar Muestra";
            this.btnGenerarNumerosAleatorios.UseVisualStyleBackColor = true;
            this.btnGenerarNumerosAleatorios.Click += new System.EventHandler(this.btnGenerarNumerosAleatorios_Click);
            // 
            // txtTamañoMuestraAGenerar
            // 
            this.txtTamañoMuestraAGenerar.Location = new System.Drawing.Point(108, 29);
            this.txtTamañoMuestraAGenerar.Name = "txtTamañoMuestraAGenerar";
            this.txtTamañoMuestraAGenerar.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoMuestraAGenerar.TabIndex = 1;
            this.txtTamañoMuestraAGenerar.Text = "30";
            this.txtTamañoMuestraAGenerar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
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
            // grpAgregarValor
            // 
            this.grpAgregarValor.Controls.Add(this.txtLista);
            this.grpAgregarValor.Location = new System.Drawing.Point(12, 239);
            this.grpAgregarValor.Name = "grpAgregarValor";
            this.grpAgregarValor.Size = new System.Drawing.Size(214, 48);
            this.grpAgregarValor.TabIndex = 9;
            this.grpAgregarValor.TabStop = false;
            this.grpAgregarValor.Text = "Agregar Valor Especifico a la Muestra";
            this.grpAgregarValor.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblTamañoMuestra
            // 
            this.lblTamañoMuestra.AutoSize = true;
            this.lblTamañoMuestra.Location = new System.Drawing.Point(396, 321);
            this.lblTamañoMuestra.Name = "lblTamañoMuestra";
            this.lblTamañoMuestra.Size = new System.Drawing.Size(87, 13);
            this.lblTamañoMuestra.TabIndex = 10;
            this.lblTamañoMuestra.Text = "Tamaño Muestra";
            // 
            // btnEliminarMuestra
            // 
            this.btnEliminarMuestra.Location = new System.Drawing.Point(6, 81);
            this.btnEliminarMuestra.Name = "btnEliminarMuestra";
            this.btnEliminarMuestra.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarMuestra.TabIndex = 3;
            this.btnEliminarMuestra.Text = "Eliminar Muestra";
            this.btnEliminarMuestra.UseVisualStyleBackColor = true;
            this.btnEliminarMuestra.Click += new System.EventHandler(this.btnEliminarMuestra_Click);
            // 
            // txtDecimales
            // 
            this.txtDecimales.Location = new System.Drawing.Point(108, 55);
            this.txtDecimales.Name = "txtDecimales";
            this.txtDecimales.Size = new System.Drawing.Size(100, 20);
            this.txtDecimales.TabIndex = 1;
            this.txtDecimales.Text = "4";
            this.txtDecimales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximo Decimales";
            // 
            // FrmAnalisisChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.lblTamañoMuestra);
            this.Controls.Add(this.grpAgregarValor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grpGeneradorMuestra);
            this.Controls.Add(this.grpIntervalos);
            this.Controls.Add(this.lblChiCuadrado);
            this.Controls.Add(this.btnTestChiCuadrado);
            this.Controls.Add(this.dgvFrecuencia);
            this.Controls.Add(this.dgvMuestra);
            this.Name = "FrmAnalisisChiCuadrado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).EndInit();
            this.grpIntervalos.ResumeLayout(false);
            this.grpIntervalos.PerformLayout();
            this.grpGeneradorMuestra.ResumeLayout(false);
            this.grpGeneradorMuestra.PerformLayout();
            this.grpAgregarValor.ResumeLayout(false);
            this.grpAgregarValor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.DataGridView dgvFrecuencia;
        private System.Windows.Forms.Button btnTestChiCuadrado;
        private System.Windows.Forms.Label lblChiCuadrado;
        private System.Windows.Forms.GroupBox grpIntervalos;
        private System.Windows.Forms.TextBox txtCantidadIntervalos;
        private System.Windows.Forms.RadioButton rdbAutomatico;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpGeneradorMuestra;
        private System.Windows.Forms.Button btnGenerarNumerosAleatorios;
        private System.Windows.Forms.TextBox txtTamañoMuestraAGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpAgregarValor;
        private System.Windows.Forms.Label lblTamañoMuestra;
        private System.Windows.Forms.Button btnEliminarMuestra;
        private System.Windows.Forms.TextBox txtDecimales;
        private System.Windows.Forms.Label label1;
    }
}
