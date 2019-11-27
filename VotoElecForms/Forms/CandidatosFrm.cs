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
        VotoClass.Clases.Candidatos mCandi = new VotoClass.Clases.Candidatos();
        #endregion

        public CandidatosFrm()
        {
            InitializeComponent();
            DisabledTxtBoxes();
            HideSaveCancelBtn();
            Refrescar();
            count();
        }

        #region methods
        private void ClearTxtBoxes()
        {
            numCedula.Text = "";
            txtBxPrimerApellido.Text = "";
            txtBxSegundoApellido.Text = "";
            txtBxNombre.Text = "";
        }

        private void HideTxtBoxes()
        {
            numCedula.Visible = false;
            txtBxPrimerApellido.Visible = false;
            txtBxSegundoApellido.Visible = false;
            txtBxNombre.Visible = false;
        }

        private void ShowTxtBoxes()
        {
            numCedula.Visible = true;
            txtBxPrimerApellido.Visible = true;
            txtBxSegundoApellido.Visible = true;
            txtBxNombre.Visible = true;
        }

        private void EnableTxtBoxes()
        {
            numCedula.Enabled = true;
            txtBxPrimerApellido.Enabled = true;
            txtBxSegundoApellido.Enabled = true;
            txtBxNombre.Enabled = true;
        }

        private void DisabledTxtBoxes()
        {
            numCedula.Enabled = false;
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

        
        private bool verify()
        {
            bool result = true;

            if (numCedula.Text.Trim() == "")
            {
                errorMark.SetError(numCedula, "Entre una Cedula");
                result = false;
            }
            else
            {
                errorMark.SetError(numCedula, "");
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

        private void Refrescar()
        {
            dgvCandidatos.DataSource = null;
            dgvCandidatos.DataSource = mCandi.ListaCandidatos();
            dgvCandidatos.AutoResizeColumns();
            dgvCandidatos.Refresh();
        }

        private void count()
        {
            if (mCandi.CantidadCandidatos() < 4)
            {
                lblCantidad.ForeColor = Color.Red;
                lblCantidad.Text = "No tiene suficiente Candidatos";
            }
            else
            {
                if (mCandi.CantidadCandidatos() > 10)
                {
                    lblCantidad.ForeColor = Color.Red;
                    lblCantidad.Text = "Tiene mas Candidatos de 10";
                }
                else
                {
                    lblCantidad.Text = "Tiene suficiente candidatos";
                }   
            }
            
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
            numCedula.Enabled = true;
            VisibleSaveCancelBtn();
            BtnSave.Text = "Buscar";
            BtnDelete.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            controll = 4;
            DisabledTxtBoxes();
            numCedula.Enabled = true;
            VisibleSaveCancelBtn();
            BtnSave.Text = "Eliminar";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DisabledTxtBoxes();
            HideSaveCancelBtn();
            ClearTxtBoxes();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                mCandi.Cedula = int.Parse(numCedula.Text.ToString().Trim());
                mCandi.Nombre = txtBxNombre.Text.ToString().Trim();
                mCandi.PrimerApellido = txtBxPrimerApellido.Text.ToString().Trim();
                mCandi.SegundoApellido = txtBxSegundoApellido.Text.ToString().Trim();
                

                if (controll == 1)
                {
                    if (mCandi.AgregarCandidato())
                    {
                        MessageBox.Show("Candidato agregado", "Agregado");
                        Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("El Candidato no fue Agregado", "Error");
                    }

                }

                if (controll == 2)
                {
                    if (mCandi.ActualizarCandidato())
                    {
                        MessageBox.Show("Candidato Actualizado", "Actualizar");
                        Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("El Candidato no fue Actualizado", "Error");
                    }
                }

                if (controll == 3)
                {
                    if (true)
                    {
                        MessageBox.Show("Candidato Buscado", "search");
                        Refrescar();
                    }
                    
                }

                if (controll == 4)
                {
                    if (MessageBox.Show("Seguro de Eliminar el Candidato?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        if (mCandi.EliminarCandidato())
                        {
                            Refrescar();
                        }
                        else
                        {
                            MessageBox.Show("El Candidato no exciste", "Error");
                        }
                    }

                }

            }
            count();
        }
    }
}
