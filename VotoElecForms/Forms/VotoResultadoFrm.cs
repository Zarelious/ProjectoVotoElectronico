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
    public partial class VotoResultadoFrm : Form
    {
        VotoClass.Clases.Candidatos mCandi = new Candidatos();

        public VotoResultadoFrm()
        {
            InitializeComponent();
            TableofWinners();
            ShowWinner();
        }

        public void ShowWinner()
        {
            mCandi.GanadorCandidato();
            lblGanador.Text = mCandi.Nombre.Trim() + " " + mCandi.PrimerApellido.Trim() + " " + mCandi.SegundoApellido;
            lblVotos.Text = mCandi.Votos.ToString() + " Votos";
        }

        public void TableofWinners()
        {
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = mCandi.ListaCandidatos();
            dgvResultados.AutoResizeColumns();
            dgvResultados.Refresh();
        }
    }
}
