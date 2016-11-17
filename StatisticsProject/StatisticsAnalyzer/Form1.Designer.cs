namespace StatisticsAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measureOfCentralTendencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measureOfDispersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measureOfDispersionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphPlotterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.measureOfCentralTendencyToolStripMenuItem,
            this.graphPlotterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(684, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // measureOfCentralTendencyToolStripMenuItem
            // 
            this.measureOfCentralTendencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.measureOfDispersionToolStripMenuItem,
            this.measureOfDispersionToolStripMenuItem1});
            this.measureOfCentralTendencyToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measureOfCentralTendencyToolStripMenuItem.Name = "measureOfCentralTendencyToolStripMenuItem";
            this.measureOfCentralTendencyToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.measureOfCentralTendencyToolStripMenuItem.Text = "Statistics";
            // 
            // measureOfDispersionToolStripMenuItem
            // 
            this.measureOfDispersionToolStripMenuItem.Name = "measureOfDispersionToolStripMenuItem";
            this.measureOfDispersionToolStripMenuItem.Size = new System.Drawing.Size(310, 24);
            this.measureOfDispersionToolStripMenuItem.Text = "Measure of Central Tendency";
            this.measureOfDispersionToolStripMenuItem.Click += new System.EventHandler(this.measureOfDispersionToolStripMenuItem_Click);
            // 
            // measureOfDispersionToolStripMenuItem1
            // 
            this.measureOfDispersionToolStripMenuItem1.Name = "measureOfDispersionToolStripMenuItem1";
            this.measureOfDispersionToolStripMenuItem1.Size = new System.Drawing.Size(310, 24);
            this.measureOfDispersionToolStripMenuItem1.Text = "Measure of Dispersion";
            this.measureOfDispersionToolStripMenuItem1.Click += new System.EventHandler(this.measureOfDispersionToolStripMenuItem1_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.refreshToolStripMenuItem.Text = "Exit";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // graphPlotterToolStripMenuItem
            // 
            this.graphPlotterToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphPlotterToolStripMenuItem.Name = "graphPlotterToolStripMenuItem";
            this.graphPlotterToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.graphPlotterToolStripMenuItem.Text = "Graph Plotter";
            this.graphPlotterToolStripMenuItem.Click += new System.EventHandler(this.graphPlotterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO THE STATISTICS ANALYZER APP. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(606, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLICK ON ANY OF THE MENU ABOVE FOR THE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "OPERATION YOU WANT TO PERFORM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measureOfCentralTendencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measureOfDispersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measureOfDispersionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem graphPlotterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

