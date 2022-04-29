
namespace lab_1
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dBTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scopesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculator1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculator2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBTablesToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dBTablesToolStripMenuItem
            // 
            this.dBTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatorsToolStripMenuItem,
            this.languagesToolStripMenuItem,
            this.scopesToolStripMenuItem});
            this.dBTablesToolStripMenuItem.Name = "dBTablesToolStripMenuItem";
            this.dBTablesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.dBTablesToolStripMenuItem.Text = "DB Tables";
            // 
            // creatorsToolStripMenuItem
            // 
            this.creatorsToolStripMenuItem.Name = "creatorsToolStripMenuItem";
            this.creatorsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.creatorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.creatorsToolStripMenuItem.Text = "Creators";
            this.creatorsToolStripMenuItem.Click += new System.EventHandler(this.creatorsToolStripMenuItem_Click);
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.languagesToolStripMenuItem.Text = "Languages";
            this.languagesToolStripMenuItem.Click += new System.EventHandler(this.languagesToolStripMenuItem_Click);
            // 
            // scopesToolStripMenuItem
            // 
            this.scopesToolStripMenuItem.Name = "scopesToolStripMenuItem";
            this.scopesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.scopesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.scopesToolStripMenuItem.Text = "Scopes";
            this.scopesToolStripMenuItem.Click += new System.EventHandler(this.scopesToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculator1ToolStripMenuItem,
            this.calculator2ToolStripMenuItem});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // calculator1ToolStripMenuItem
            // 
            this.calculator1ToolStripMenuItem.Name = "calculator1ToolStripMenuItem";
            this.calculator1ToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.calculator1ToolStripMenuItem.Text = "Calculator 1";
            this.calculator1ToolStripMenuItem.Click += new System.EventHandler(this.calculator1ToolStripMenuItem_Click);
            // 
            // calculator2ToolStripMenuItem
            // 
            this.calculator2ToolStripMenuItem.Name = "calculator2ToolStripMenuItem";
            this.calculator2ToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.calculator2ToolStripMenuItem.Text = "Calculator 2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 162);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Languages";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dBTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scopesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculator1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculator2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

