using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab_1;

namespace programming_languages
{
    public partial class TableScopes : Form
    {
        int rowEdit = -1;
        int colEdit = -1;

        public TableScopes()
        {
            InitializeComponent();
        }

        private void TableScopes_Load(object sender, EventArgs e)
        {
            DB.bs1 = new BindingSource();
            DB.bs1.DataSource = DB.myDataTable("SELECT * FROM scopes");
            dataGridView1.DataSource = DB.bs1;

            this.scopesDVGFormat();
            bindingNavigator1.BindingSource = DB.bs1;
        }

        private void scopesDVGFormat()
        {
            // Ширина стовпця (поля)
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 260;
            // назви полів (стовпців)
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].HeaderText = "Description";

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.Padding = new Padding(4, 4, 4, 4);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOliveGreen;



            if (int.Parse(DB.typeUser) > 2)
            {
                dataGridView1.ReadOnly = true;
            }

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.EditType !=
                typeof(DataGridViewTextBoxEditingControl)) return;

            rowEdit = dataGridView1.CurrentCell.RowIndex;
            colEdit = dataGridView1.CurrentCell.ColumnIndex;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (colEdit == -1) return;

            var c = colEdit;
            var r = rowEdit;

            colEdit = -1;
            rowEdit = -1;

            dataGridView1.CurrentCell = dataGridView1[c, r];
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else
            {
                int ri, ci;

                if (e.KeyCode == Keys.Enter)
                {
                    ri = dataGridView1.CurrentCell.RowIndex;
                    ci = dataGridView1.CurrentCell.ColumnIndex;

                    e.SuppressKeyPress = true;

                    if (dataGridView1.Columns.Count > ci + 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[ri].Cells[ci + 1];

                        return;
                    }
                    else
                    {
                        if (dataGridView1.Rows.Count > ri + 1)
                            dataGridView1.CurrentCell = dataGridView1.Rows[ri + 1].Cells[0];
                    }
                }
            }
        }
    }
}
