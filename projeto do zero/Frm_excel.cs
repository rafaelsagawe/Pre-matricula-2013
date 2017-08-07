using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;

namespace projeto_do_zero
{
    public partial class Frm_excel : Form
    {
        public Frm_excel()
        {
            InitializeComponent();
        }

        private void cadastroDEalunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroDEalunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Frm_excel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.cadastroDEaluno' table. You can move, or remove it, as needed.
            this.cadastroDEalunoTableAdapter.Fill(this.databaseDataSet.cadastroDEaluno);
            // TODO: This line of code loads data into the 'databaseDataSet.cadastroDEaluno' table. You can move, or remove it, as needed.
            this.cadastroDEalunoTableAdapter.Fill(this.databaseDataSet.cadastroDEaluno);

        }
        private void cadastroDEalunoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroDEalunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void cadastroDEalunoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Microsoft.Office.Interop.Excel.Application excelapp =
                       new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel._Workbook workbook =
                        excelapp.Workbooks.Add(Type.Missing);

                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                    excelapp.Visible = true;

                    try
                    {
                        // pegando a primeira planilha do excel;
                        // deixando-a como ativa e ao final, 
                        // será atribuido um nome a ela.
                        worksheet = (Worksheet)workbook.Sheets["Plan1"];
                        worksheet = (Worksheet)workbook.ActiveSheet;
                        worksheet.Name = "Exportado de um DataGridView";

                        // pegando os nomes das colunas do DataGridView
                        for (int i = 1; i < cadastroDEalunoDataGridView.Columns.Count + 1; i++)
                        {
                            worksheet.Cells[1, i] =
                                cadastroDEalunoDataGridView.Columns[i - 1].HeaderText;
                        }

                        // fazendo um loop no DataGridView, que recupera as rows
                        // do DataGridView, correspondente a cada column.
                        for (int i = 0; i < cadastroDEalunoDataGridView.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < cadastroDEalunoDataGridView.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] =
                                    cadastroDEalunoDataGridView.Rows[i].Cells[j].Value.ToString();
                            }
                        }

                        // ao final, salva no formato do Excel.
                        workbook.SaveAs(@"C:\DGVToExcel.xlsx",
                            Type.Missing, Type.Missing, Type.Missing,
                            Type.Missing, Type.Missing,
                            Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                            Type.Missing, Type.Missing, Type.Missing,
                            Type.Missing, Type.Missing);

                        MessageBox.Show("Arquivo criado com sucesso");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }

                }
            }
        }
        }
}

