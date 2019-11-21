using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotoElecForms.Forms
{
    public partial class VotoFrm : Form
    {
        public VotoFrm()
        {
            InitializeComponent();
            HidePanel();
        }
         private void ShowPanel()
        {
            pnlCandidato.Visible = true;
        }

        private void HidePanel()
        {
            pnlCandidato.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ShowPanel();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
