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
        public int Votos { get; set; }


        public bool AgregarCandidato()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta =
                new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
            try
            {
                mta.InsertQuery(Nombre, PrimerApellido, SegundoApellido, Cedula, Votos);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarCandidato()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta =
                new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
            try
            {
                mta.UpdateQuery(Nombre, PrimerApellido, SegundoApellido, Cedula, Votos);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarCandidato()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta =
                new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
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
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta =
                new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
            Voto_ElectronicoDataSet mds = new Voto_ElectronicoDataSet();


            try
            {
                mta.Fill(mds.Candidatos);
                return mds.Candidatos;
            }
            catch
            {
                return mds.Candidatos;
            }
        }

        public int CantidadCandidatos()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();

            try
            {
                return (int) mta.QtyQuery();
            }
            catch 
            {
                return 0;

            }
        }

        public Voto_ElectronicoDataSet.CandidatosDataTable GanadorCandidato()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta =
                new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
            Voto_ElectronicoDataSet mds = new Voto_ElectronicoDataSet();

            try
            {
                mta.WinnerQuery(mds.Candidatos);
                if (mds.Candidatos.Rows.Count == 1)
                {
                    Voto_ElectronicoDataSet.CandidatosRow mRow =
                        (Voto_ElectronicoDataSet.CandidatosRow) mds.Candidatos.Rows[0];
                    Nombre = mRow.Nombre;
                    PrimerApellido = mRow.PrimerApellido;
                    SegundoApellido = mRow.SegundoApellido;
                    Cedula = mRow.Cedula;
                    Votos = mRow.Votos;
                    return mds.Candidatos;
                }
                else
                {
                    return mds.Candidatos;
                }
               
            }
            catch (Exception e)
            {
               Console.WriteLine(e);
                throw;
               
            }
            
        }

        public bool SearchCandidatos()
        {
            Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter mta =
                new Voto_ElectronicoDataSetTableAdapters.CandidatosTableAdapter();
            Voto_ElectronicoDataSet mds = new Voto_ElectronicoDataSet();

            mta.FillByCandidatos(mds.Candidatos, Cedula);
            if (mds.Candidatos.Rows.Count == 1)
            {
                Voto_ElectronicoDataSet.CandidatosRow mRow =
                    (Voto_ElectronicoDataSet.CandidatosRow)mds.Candidatos.Rows[0];
                Nombre = mRow.Nombre;
                PrimerApellido = mRow.PrimerApellido;
                SegundoApellido = mRow.SegundoApellido;
                Cedula = mRow.Cedula;
                Votos = mRow.Votos;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
