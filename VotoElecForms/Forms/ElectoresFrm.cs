using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotoElecForms.Forms
{

    public partial class ElectoresFrm : Form
    {
        

        #region veriables

        private int controll = 0;
        VotoClass.Clases.Electores mElec = new VotoClass.Clases.Electores();
        public int mIndex { get; set; }

        #endregion

        public ElectoresFrm()
        {
            InitializeComponent();
            ClearTxtBoxes();
            HideSaveCancelBtn();
            DisabledTxtBoxes();
            Refrescar();
        }

        #region methods
        private void ClearTxtBoxes()
        {
            numCedula.Text = "";
            txtBxPrimerApellido.Text = "";
            txtBxSegundoApellido.Text = "";
            txtBxNombre.Text = "";
            dtpNacimiento.Refresh();
        }

        private void HideTxtBoxes()
        {
            numCedula.Visible = false;
            txtBxPrimerApellido.Visible = false;
            txtBxSegundoApellido.Visible = false;
            txtBxNombre.Visible = false;
            dtpNacimiento.Visible = false;
        }

        private void ShowTxtBoxes()
        {
            numCedula.Visible = true;
            txtBxPrimerApellido.Visible = true;
            txtBxSegundoApellido.Visible = true;
            txtBxNombre.Visible = true;
            dtpNacimiento.Visible = true;
        }

        private void EnableTxtBoxes()
        {
            numCedula.Enabled = true;
            txtBxPrimerApellido.Enabled = true;
            txtBxSegundoApellido.Enabled = true;
            txtBxNombre.Enabled = true;
            dtpNacimiento.Enabled = true;
        }

        private void DisabledTxtBoxes()
        {
            numCedula.Enabled = false;
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
        public void Refrescar()
        {
            dgvElectores.DataSource = null;
            dgvElectores.DataSource = mElec.ListaElectores();
            dgvElectores.AutoResizeColumns();
            dgvElectores.Refresh();
        }

        public string radioChoice()
        {
            if (rbtnYes.Checked == true)
            {
                return "Si";
            }
            else
            {
                return "No";
            }
        }
        private void dgvElectores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mIndex = e.RowIndex;
                DataGridViewRow sViewRow = dgvElectores.Rows[mIndex];
                numCedula.Text = sViewRow.Cells[5].Value.ToString();
                txtBxNombre.Text = sViewRow.Cells[0].Value.ToString();
                txtBxPrimerApellido.Text = sViewRow.Cells[1].Value.ToString();
                txtBxSegundoApellido.Text = sViewRow.Cells[2].Value.ToString();
                dtpNacimiento.Text = sViewRow.Cells[3].Value.ToString();


            }
            catch
            {

            }
        }
        #endregion methods



        private void btnAdd_Click(object sender, EventArgs e)
        {
            controll = 1;
            EnableTxtBoxes();
            VisibleSaveCancelBtn();
            btnSave.Text = "Guardar";

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controll = 2;
            EnableTxtBoxes();
            VisibleSaveCancelBtn();
            btnSave.Text = "Guardar";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            controll = 3;
            DisabledTxtBoxes();
            numCedula.Enabled = true;
            VisibleSaveCancelBtn();
            btnSave.Text = "Buscar";
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            controll = 4;
            DisabledTxtBoxes();
            numCedula.Enabled = true;
            VisibleSaveCancelBtn();
            btnSave.Text = "Eliminar";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisabledTxtBoxes();
            HideSaveCancelBtn();
            ClearTxtBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                
                
                mElec.Cedula = int.Parse(numCedula.Text.ToString().Trim());
                mElec.Nombre = txtBxNombre.Text.ToString().Trim();
                mElec.PrimerApellido = txtBxPrimerApellido.Text.ToString().Trim();
                mElec.SegundoApellido = txtBxSegundoApellido.Text.ToString().Trim();
                mElec.FechaNacimiento = Convert.ToDateTime(dtpNacimiento.Text.ToString().Trim());
                mElec.ProblemasJudiciales = radioChoice();

                if (controll == 1)
                {
                    if (mElec.AgregarElector())
                    {
                        MessageBox.Show("Elector agregado", "Agregado");
                        Refrescar();
                        ClearTxtBoxes();
                        DisabledTxtBoxes();
                        HideSaveCancelBtn();
                    }
                    else
                    {
                        MessageBox.Show("El Elector no fue Agregado", "Error");
                    }

                }

                if (controll == 2)
                {
                    if (mElec.ActualizarElector())
                    {
                        MessageBox.Show("Elector Actualizado", "Actualizar");
                        Refrescar();
                        ClearTxtBoxes();
                        DisabledTxtBoxes();
                        HideSaveCancelBtn();
                    }
                    else
                    {
                        MessageBox.Show("El Elector no fue Actualizado", "Error");
                    }
                }

                if (controll == 3)
                {
                    try
                    {
                        mElec.SearchTable();
                        numCedula.Text = mElec.Cedula.ToString();
                        txtBxNombre.Text = mElec.Nombre.ToString();
                        txtBxPrimerApellido.Text = mElec.PrimerApellido.ToString();
                        txtBxSegundoApellido.Text = mElec.SegundoApellido.ToString();
                        dtpNacimiento.Text = mElec.FechaNacimiento.ToString();
                        dgvElectores.DataSource = null;
                        dgvElectores.DataSource = mElec.SearchTable();
                        dgvElectores.AutoResizeColumns();
                        dgvElectores.Refresh();
                        ClearTxtBoxes();
                        DisabledTxtBoxes();
                        HideSaveCancelBtn();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Elector no fue Encontrado", "search");
                        Console.WriteLine(exception);
                        throw;
                    }
                    
                    
                }

                if (controll == 4)
                {
                    if (MessageBox.Show("Seguro de Eliminar el Elector?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        if (mElec.EliminarElector())
                        {
                            Refrescar();
                            ClearTxtBoxes();
                            DisabledTxtBoxes();
                            HideSaveCancelBtn();
                        }
                        else
                        {
                            MessageBox.Show("El Elector no exciste", "Error");
                        }
                    }
                    
                }
                
            }
            
        }

        
    }
}
