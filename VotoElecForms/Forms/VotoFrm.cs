using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotoClass.Clases;

namespace VotoElecForms.Forms
{
    public partial class VotoFrm : Form
    {
        public VotoFrm()
        {
            InitializeComponent();
            HidePanel();
            fillComboBox();
        }

        #region methods

        private void ShowPanel()
        {
            pnlCandidato.Visible = true;
        }

        private void HidePanel()
        {
            pnlCandidato.Visible = false;
        }

        private void fillComboBox()
        {
            VotoClass.Clases.Candidatos mCandi = new Candidatos();
            cbxCandidatos.DisplayMember = "Nombre";
            cbxCandidatos.ValueMember = "Cedula";
            cbxCandidatos.DataSource = mCandi.ListaCandidatos();
        }

        #endregion

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
