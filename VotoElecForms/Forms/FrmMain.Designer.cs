namespace VotoElecForms
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.votoElectronicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electorresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votoElectronicoToolStripMenuItem,
            this.registracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(833, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // votoElectronicoToolStripMenuItem
            // 
            this.votoElectronicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votacionToolStripMenuItem,
            this.ganadorToolStripMenuItem});
            this.votoElectronicoToolStripMenuItem.Name = "votoElectronicoToolStripMenuItem";
            this.votoElectronicoToolStripMenuItem.Size = new System.Drawing.Size(105, 19);
            this.votoElectronicoToolStripMenuItem.Text = "Voto Electronico";
            // 
            // registracionToolStripMenuItem
            // 
            this.registracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candidatosToolStripMenuItem,
            this.electorresToolStripMenuItem});
            this.registracionToolStripMenuItem.Name = "registracionToolStripMenuItem";
            this.registracionToolStripMenuItem.Size = new System.Drawing.Size(84, 19);
            this.registracionToolStripMenuItem.Text = "Registracion";
            // 
            // candidatosToolStripMenuItem
            // 
            this.candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            this.candidatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.candidatosToolStripMenuItem.Text = "Candidatos";
            this.candidatosToolStripMenuItem.Click += new System.EventHandler(this.candidatosToolStripMenuItem_Click);
            // 
            // electorresToolStripMenuItem
            // 
            this.electorresToolStripMenuItem.Name = "electorresToolStripMenuItem";
            this.electorresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.electorresToolStripMenuItem.Text = "Electores";
            this.electorresToolStripMenuItem.Click += new System.EventHandler(this.electorresToolStripMenuItem_Click);
            // 
            // votacionToolStripMenuItem
            // 
            this.votacionToolStripMenuItem.Name = "votacionToolStripMenuItem";
            this.votacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.votacionToolStripMenuItem.Text = "Votacion";
            this.votacionToolStripMenuItem.Click += new System.EventHandler(this.votacionToolStripMenuItem_Click);
            // 
            // ganadorToolStripMenuItem
            // 
            this.ganadorToolStripMenuItem.Name = "ganadorToolStripMenuItem";
            this.ganadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ganadorToolStripMenuItem.Text = "Ganador";
            this.ganadorToolStripMenuItem.Click += new System.EventHandler(this.ganadorToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 557);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmMain";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem votoElectronicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electorresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganadorToolStripMenuItem;
    }
}

