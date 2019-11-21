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
        public ElectoresFrm()
        {
            InitializeComponent();
        }
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
    }
}
