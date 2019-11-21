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
    public partial class ElectoresFrm : Form
    {
        #region veriables

        private int controll = 0;

        #endregion

        public ElectoresFrm()
        {
            InitializeComponent();
        }
        #region methods
        private void ClearTxtBoxes()
        {
            txtBxCedula.Text = "";
            txtBxPrimerApellido.Text = "";
            txtBxSegundoApellido.Text = "";
            txtBxNombre.Text = "";
            dtpNacimiento.Refresh();
        }

        private void HideTxtBoxes()
        {
            txtBxCedula.Visible = false;
            txtBxPrimerApellido.Visible = false;
            txtBxSegundoApellido.Visible = false;
            txtBxNombre.Visible = false;
            dtpNacimiento.Visible = false;
        }

        private void ShowTxtBoxes()
        {
            txtBxCedula.Visible = true;
            txtBxPrimerApellido.Visible = true;
            txtBxSegundoApellido.Visible = true;
            txtBxNombre.Visible = true;
            dtpNacimiento.Visible = true;
        }

        private void EnableTxtBoxes()
        {
            txtBxCedula.Enabled = true;
            txtBxPrimerApellido.Enabled = true;
            txtBxSegundoApellido.Enabled = true;
            txtBxNombre.Enabled = true;
            dtpNacimiento.Enabled = true;
        }

        private void DisabledTxtBoxes()
        {
            txtBxCedula.Enabled = false;
            txtBxPrimerApellido.Enabled = false;
            txtBxSegundoApellido.Enabled = false;
            txtBxNombre.Enabled = false;
            dtpNacimiento.Enabled = false;
        }

        private void VisibleSaveCancelBtn()
        {
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void HideSaveCancelBtn()
        {
            btnSave.Visible = false;
            btnSave.Visible = false;
        }

        #endregion methods
        

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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            controll = 1;
            EnableTxtBoxes();
            VisibleSaveCancelBtn();
            btnSave.Text = "Guardar";
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            controll = 2;
            EnableTxtBoxes();
            VisibleSaveCancelBtn();
            btnSave.Text = "Guardar";
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            controll = 3;
            DisabledTxtBoxes();
            txtBxCedula.Enabled = true;
            VisibleSaveCancelBtn();
            btnSave.Text = "Buscar";
            btnDelete.Visible = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            controll = 4;
            DisabledTxtBoxes();
            txtBxCedula.Enabled = true;
            VisibleSaveCancelBtn();
            btnSave.Text = "Eliminar";
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DisabledTxtBoxes();
            HideSaveCancelBtn();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
