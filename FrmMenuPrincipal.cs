﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnalisisChiCuadrado form = new FrmAnalisisChiCuadrado();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGeneradorPseudoAleatorio form = new FrmGeneradorPseudoAleatorio();
            form.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Equals("EXCEL"))
                {
                    clsProcess.Kill();
                    //break;
                }
            }
            this.Dispose();
        }
    }
}
