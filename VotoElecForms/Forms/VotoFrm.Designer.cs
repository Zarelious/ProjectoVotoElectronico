namespace VotoElecForms.Forms
{
    partial class VotoFrm
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumBxCedula = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCandidato = new System.Windows.Forms.Panel();
            this.cbxCandidatos = new System.Windows.Forms.ComboBox();
            this.btnSaveCandidato = new System.Windows.Forms.Button();
            this.bntCancelCandidato = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtbxExit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBxCedula)).BeginInit();
            this.pnlCandidato.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cedula Fisica o Cedula de Residencia";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 100);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Voto Electronico";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NumBxCedula);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pnlCandidato);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 298);
            this.panel2.TabIndex = 21;
            // 
            // NumBxCedula
            // 
            this.NumBxCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBxCedula.Location = new System.Drawing.Point(49, 104);
            this.NumBxCedula.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumBxCedula.Name = "NumBxCedula";
            this.NumBxCedula.Size = new System.Drawing.Size(420, 29);
            this.NumBxCedula.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(395, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 260);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(91, 35);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Electorial";
            // 
            // pnlCandidato
            // 
            this.pnlCandidato.Controls.Add(this.cbxCandidatos);
            this.pnlCandidato.Controls.Add(this.btnSaveCandidato);
            this.pnlCandidato.Controls.Add(this.bntCancelCandidato);
            this.pnlCandidato.Controls.Add(this.label2);
            this.pnlCandidato.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCandidato.Location = new System.Drawing.Point(492, 0);
            this.pnlCandidato.Name = "pnlCandidato";
            this.pnlCandidato.Size = new System.Drawing.Size(398, 298);
            this.pnlCandidato.TabIndex = 20;
            // 
            // cbxCandidatos
            // 
            this.cbxCandidatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCandidatos.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCandidatos.FormattingEnabled = true;
            this.cbxCandidatos.Location = new System.Drawing.Point(104, 103);
            this.cbxCandidatos.Name = "cbxCandidatos";
            this.cbxCandidatos.Size = new System.Drawing.Size(189, 32);
            this.cbxCandidatos.TabIndex = 27;
            // 
            // btnSaveCandidato
            // 
            this.btnSaveCandidato.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCandidato.Location = new System.Drawing.Point(304, 257);
            this.btnSaveCandidato.Name = "btnSaveCandidato";
            this.btnSaveCandidato.Size = new System.Drawing.Size(91, 35);
            this.btnSaveCandidato.TabIndex = 26;
            this.btnSaveCandidato.Text = "Guardar";
            this.btnSaveCandidato.UseVisualStyleBackColor = true;
            this.btnSaveCandidato.Click += new System.EventHandler(this.btnSaveCandidato_Click);
            // 
            // bntCancelCandidato
            // 
            this.bntCancelCandidato.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancelCandidato.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelCandidato.Location = new System.Drawing.Point(7, 260);
            this.bntCancelCandidato.Name = "bntCancelCandidato";
            this.bntCancelCandidato.Size = new System.Drawing.Size(91, 35);
            this.bntCancelCandidato.TabIndex = 25;
            this.bntCancelCandidato.Text = "Cancelar";
            this.bntCancelCandidato.UseVisualStyleBackColor = true;
            this.bntCancelCandidato.Click += new System.EventHandler(this.bntCancelCandidato_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Candidato";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(690, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 50);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtbxExit);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 50);
            this.panel5.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(146, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(54, 50);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtbxExit
            // 
            this.txtbxExit.Location = new System.Drawing.Point(4, 27);
            this.txtbxExit.Name = "txtbxExit";
            this.txtbxExit.Size = new System.Drawing.Size(144, 20);
            this.txtbxExit.TabIndex = 25;
            // 
            // VotoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 448);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VotoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VotoFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBxCedula)).EndInit();
            this.pnlCandidato.ResumeLayout(false);
            this.pnlCandidato.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCandidato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnSaveCandidato;
        private System.Windows.Forms.Button bntCancelCandidato;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbxCandidatos;
        private System.Windows.Forms.NumericUpDown NumBxCedula;
        private System.Windows.Forms.TextBox txtbxExit;
    }
}