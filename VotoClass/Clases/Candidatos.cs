using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotoClass.Clases
{
   public class Candidatos
    {
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Cedula { get; set; }

        public bool AgregarCandidato()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
            try
            {
                mta.InsertQuery(Nombre, PrimerApellido, SegundoApellido, Cedula);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool ActualizarCandidato()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
            try
            {
                mta.UpdateQuery(Nombre, PrimerApellido, SegundoApellido, Cedula);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool EliminarCandidato()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
            try
            {
                mta.DeleteQuery(Cedula);
                return true;
            }
            catch
            {
                return false;
            }

        }

       
            public Voto_ElectronicoDataSet.CandidatosDataTable ListaCandidatos()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
            Voto_ElectronicoDataSet mds = new Voto_ElectronicoDataSet();
             
            
            try
            {
                mta.Fill(mds.Candidatos);
                return mds.Candidatos;
            }
            catch { return mds.Candidatos; }
        }


    }
}
