﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MenuStrip
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                if (textBox1.Text == "usuario1" || textBox2.Text == "clave1")
                {
                    Dialogos principal = new Dialogos();
                    principal.Show();
                    this.Hide();
                }
            
            else
            {
                MessageBox.Show("Error de usuario o clave de acceso", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 

