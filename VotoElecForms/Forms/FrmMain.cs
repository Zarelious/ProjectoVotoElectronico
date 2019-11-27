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
using VotoElecForms.Forms;

namespace VotoElecForms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mFrm = new CandidatosFrm();
            mFrm.MdiParent = this;
            mFrm.Show();
        }

        private void electorresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mFrm = new ElectoresFrm();
            mFrm.MdiParent = this;
            mFrm.Show();
        }

        private void votacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VotoClass.Clases.Candidatos mCandi = new Candidatos();
            //if (mCandi.CantidadCandidatos() >4 && (mCandi.CantidadCandidatos() < 10))
            //{
            //    var mFrm = new VotoFrm();
            //    mFrm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Revise el los Candidatos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            var mFrm = new VotoFrm();
            mFrm.Show();
        }

        private void ganadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mFrm = new VotoResultadoFrm();
            mFrm.MdiParent = this;
            mFrm.Show();
        }
    }
}
