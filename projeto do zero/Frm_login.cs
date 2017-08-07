using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_do_zero
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                //int result = equipeTableAdapter.FillByEquipeLogin(_Database_para_C_DataSet.equipe, textBox1.Text, textBox2.Text);
                //if (result == 1)

                //login pre programado
                //if ((cbB_login.Text == "Cadastrar aluno") && (textBox2.Text == "123"))
                if (mTB_senha.Text == "123")

                //chamando tela principal da aplicação
                {
                    Frm_cadastro frap = new Frm_cadastro();
                    frap.Show();
                    this.Visible = false;
                }
                else
                {
                    // resultado negativo do teste do login
                    MessageBox.Show("Usuario ou senha invalidos", "Ocorreu um erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
           
}