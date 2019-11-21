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
    public partial class CandidatosFrm : Form
    {
        #region variables

        private int controll = 0;

        #endregion

        public CandidatosFrm()
        {
            InitializeComponent();
            DisabledTxtBoxes();
            HideSaveCancelBtn();
        }
        #region methods
        private void ClearTxtBoxes()
        {
            txtBxCedula.Text = "";
            txtBxPrimerApellido.Text = "";
            txtBxSegundoApellido.Text = "";
            txtBxNombre.Text = "";
        }

        private void HideTxtBoxes()
        {
            txtBxCedula.Visible = false;
            txtBxPrimerApellido.Visible = false;
            txtBxSegundoApellido.Visible = false;
            txtBxNombre.Visible = false;
        }

        private void ShowTxtBoxes()
        {
            txtBxCedula.Visible = true;
            txtBxPrimerApellido.Visible = true;
            txtBxSegundoApellido.Visible = true;
            txtBxNombre.Visible = true;
        }

        private void EnableTxtBoxes()
        {
            txtBxCedula.Enabled = true;
            txtBxPrimerApellido.Enabled = true;
            txtBxSegundoApellido.Enabled = true;
            txtBxNombre.Enabled = true;
        }

        private void DisabledTxtBoxes()
        {
            txtBxCedula.Enabled = false;
            txtBxPrimerApellido.Enabled = false;
            txtBxSegundoApellido.Enabled = false;
            txtBxNombre.Enabled = false;
        }

        private void VisibleSaveCancelBtn()
        {
            BtnSave.Visible = true;
            BtnCancel.Visible = true;
        }

        private void HideSaveCancelBtn()
        {
            BtnSave.Visible = false;
            BtnCancel.Visible = false;
            BtnDelete.Visible = false;
        }

        #endregion methods

        private void btnAdd_Click(object sender, EventArgs e)
        {
            controll = 1;
            EnableTxtBoxes();
            VisibleSaveCancelBtn();
            BtnSave.Text = "Guardar";
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            controll = 2;
            EnableTxtBoxes();
            VisibleSaveCancelBtn();
            BtnSave.Text = "Guardar";
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            controll = 3;
            DisabledTxtBoxes();
            txtBxCedula.Enabled = true;
            VisibleSaveCancelBtn();
            BtnSave.Text = "Buscar";
            BtnDelete.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            controll = 4;
            DisabledTxtBoxes();
            txtBxCedula.Enabled = true;
            VisibleSaveCancelBtn();
            BtnSave.Text = "Eliminar";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DisabledTxtBoxes();
            HideSaveCancelBtn();
        }

        private bool verify()
        {
            bool result = true;

            if (txtBxCedula.Text.Trim() == "")
            {
                errorMark.SetError(txtBxCedula, "Entre una Cedula");
                result = false;
            }
            else
            {
                errorMark.SetError(txtBxCedula, "");
            }

            if (controll != 3)
            {
                if (txtBxNombre.Text.Trim() == "")
                {
                    errorMark.SetError(txtBxNombre, "Entre una Nombre");
                    result = false;
                }
                else
                {
                    errorMark.SetError(txtBxNombre, "");
                }

                if (txtBxPrimerApellido.Text.Trim() == "")
                {
                    errorMark.SetError(txtBxPrimerApellido, "Entre el Apellido");
                    result = false;
                }
                else
                {
                    errorMark.SetError(txtBxPrimerApellido, "");
                }

                if (txtBxSegundoApellido.Text.Trim() == "")
                {
                    errorMark.SetError(txtBxSegundoApellido, "Entre un Apellido");
                    result = false;
                }
                else
                {
                    errorMark.SetError(txtBxSegundoApellido, "");
                }
            }

            return result;
        }
    }
}
