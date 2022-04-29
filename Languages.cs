using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Languages : Form
    {

        int rowEdit = -1;
        int colEdit = -1;

        public Languages()
        {
            InitializeComponent();
        }

        private void Languages_Load(object sender, EventArgs e)
        {
            DB.bs1 = new BindingSource();
            DB.bs1.DataSource = DB.myDataTable(
                "SELECT id_language, name, year, " +
                "title, description, first_name, last_name, birthday, country, age " +
                "FROM languages AS lang " +
                "JOIN scopes AS sc ON lang.scope_id = sc.scope_id " +
                "JOIN creators AS cr ON lang.creator_id = cr.creator_id");
            dataGridView1.DataSource = DB.bs1;

            this.languagesDVGFormat();

            bindingNavigator1.BindingSource = DB.bs1;
        }

        private void languagesDVGFormat()
        {
            string[] Titles = { 
                "ID", "Language", "Year of creation", "Scope", 
                "About scope", "Creator name", "Creator last name",
                "Creator birthday", "Creator country", "Creator age"
            };

            for (int i = 0; i <= 9; i++)
                dataGridView1.Columns[i].HeaderText = Titles[i];

            dataGridView1.Columns[0].Width = 35;

            for (int i = 1; i <= 9; i++)
                dataGridView1.Columns[i].Width = 180;
            

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.Padding = new Padding(4, 4, 4, 4);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;



            if (int.Parse(DB.typeUser) > 2)
            {
                dataGridView1.ReadOnly = true;
            }

        }

        private void coreBindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
