using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VideoAlstom
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btVideo1_Click(object sender, EventArgs e)
        {
            Login login = new Login(1);            
            login.Show();
        }

        private void btVideo2_Click(object sender, EventArgs e)
        {
            Login login = new Login(2);
            login.Show();
        }

        private void btVideo3_Click(object sender, EventArgs e)
        {
            Login login = new Login(3);
            login.Show();
        }

        private void btVideo4_Click(object sender, EventArgs e)
        {
            Login login = new Login(4);
            login.Show();
        }

        private void btVideo5_Click(object sender, EventArgs e)
        {
            Login login = new Login(5);
            login.Show();

        }

        private void btVideo6_Click(object sender, EventArgs e)
        {
            Login login = new Login(6);
            login.Show();
        }

        private void btVideo7_Click(object sender, EventArgs e)
        {
            Login login = new Login(7);
            login.Show();

        }

        private void btVideo8_Click(object sender, EventArgs e)
        {
            Login login = new Login(8);
            login.Show();
        }

        private void btVideo9_Click(object sender, EventArgs e)
        {
            Login login = new Login(9);
            login.Show();
        }

        private void btVideo10_Click(object sender, EventArgs e)
        {
            Login login = new Login(10);
            login.Show();
        }


        private bool obrigatorioSenha()
        {
            string titulo = "";
            MessageBoxButtons botao = MessageBoxButtons.OK;
            if (tbSair.Text == "")
            {
                MessageBox.Show("O CAMPO SENHA É OBRIGATÓRIO!", titulo, botao, MessageBoxIcon.Error);
                this.ActiveControl = tbSair;
                return false;
            }

            return true;
        }


        private void btSair_Click(object sender, EventArgs e)
        {
            pnSair.Visible = true;
            pnSair.Location = new Point((this.Width / 2) - (pnSair.Width / 2), (this.Height / 2) - (pnSair.Height / 2));
            tbSair.Focus();
        }

        private void btfecharsair_Click(object sender, EventArgs e)
        {
            pnSair.Visible = false;
        }

        private void btFechaPrograma_Click(object sender, EventArgs e)
        {

            if (obrigatorioSenha())
            {
                if( tbSair.Text.ToString() == "master123" ){
                    Application.Exit();
                }
                else{
                    MessageBox.Show("A SENHA ESTÁ INCORRETA!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSair.Clear();
                    this.ActiveControl = tbSair;
                }
            }
        }


    }
}
