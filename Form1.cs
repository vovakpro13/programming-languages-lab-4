using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using programming_languages;

namespace lab_1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutWindow = new About();
            aboutWindow.ShowDialog();
        }

        private void calculator1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.ShowDialog();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableCreators tCreators = new TableCreators();
            tCreators.ShowDialog();
        }

        private void languagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Languages languagesWindow = new Languages();
            languagesWindow.ShowDialog();
        }

        private void scopesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableScopes scopesWindow = new TableScopes();
            scopesWindow.ShowDialog();
        }
    }
}
