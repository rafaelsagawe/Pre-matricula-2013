using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_do_zero
{
    public partial class Frm_cadastro : Form
    {

        
        public Frm_cadastro()
        {

            InitializeComponent();
            
        }

        private void cadastroDEalunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroDEalunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Frm_cadastro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.cadastroDEaluno' table. You can move, or remove it, as needed.
            this.cadastroDEalunoTableAdapter.Fill(this.databaseDataSet.cadastroDEaluno);
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
                this.Validate();
                this.cadastroDEalunoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.databaseDataSet);
                Frm_excel frm = new Frm_excel();
                frm.ShowDialog();
            }
    
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_sobre frm = new Frm_sobre();
            frm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    this.Validate();
                    this.cadastroDEalunoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.databaseDataSet);
                    MessageBox.Show("Registro salvo e encerrando a aplicação", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Application.Exit();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void portador_De_Necessidade_EspecialCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
       

        private void cadastroDEalunoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        
        }
    }
    
}
