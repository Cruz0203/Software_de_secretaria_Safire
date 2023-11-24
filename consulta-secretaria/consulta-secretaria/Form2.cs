﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consulta_secretaria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //limpa a textbox de justificativa
        {
            boxJustificativa.Text = string.Empty;
        }

        private void enviarButton_Click(object sender, EventArgs e)
        {
            if(boxJustificativa.Text == "")
            {
                MessageBox.Show("Por favor, informe uma justificativa.");
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
