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
            FillComboBox();
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

        private void FillComboBox()
        {
            VotoClass.Clases.Candidatos mCandi = new Candidatos();
            cbxCandidatos.DisplayMember = "Nombre";
            cbxCandidatos.ValueMember = "Cedula";
            cbxCandidatos.DataSource = mCandi.ListaCandidatos();
        }

        private void ClearBoxs()
        {
            NumBxCedula.Value = 0;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            VotoClass.Clases.Electores mElectores = new Electores();
            mElectores.Cedula = int.Parse(NumBxCedula.Text.ToString().Trim());
            mElectores.SearchTable();
            VotoClass.Clases.Verificar mVerificar = new Verificar();

            if (mVerificar.EdadVerificacion(mElectores.FechaNacimiento) && mElectores.ProblemasJudiciales == "No")
            {
                ShowPanel();
                ClearBoxs();

            }
            else
            {
                MessageBox.Show("No es major de 18 anos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearBoxs();
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtbxExit.Text.Trim()  == "TerminarelVoto")
            {
                if (MessageBox.Show("Seguro que quere salir de la pantalla de voto?", "Terminar Voto",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Close();
                }
                
            }
            
            
        }

        private void btnSaveCandidato_Click(object sender, EventArgs e)
        {
            VotoClass.Clases.Verificar mVerificar = new Verificar();
            if (mVerificar.GuardarVoto(Convert.ToInt32(cbxCandidatos.SelectedValue)))
            {
                MessageBox.Show("Voto Guardado", "Voto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HidePanel();
            }
            else
            {
                MessageBox.Show("Error Contacte un Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HidePanel();
            }
        }

        private void bntCancelCandidato_Click(object sender, EventArgs e)
        {
            HidePanel();
        }
    }
}
