using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotoClass.Clases
{
    public class Resultados
    {
        public String Ganador { get; set; }
        public int VotosCandidato1 { get; set; }
        public int VotosCandidato2 { get; set; }

        public int VotosCandidato3 { get; set; }
        public int VotosCandidato4 { get; set; }
        public int VotosCandidato5 { get; set; }
        public int VotosCandidato6 { get; set; }
        public int VotosCandidato7 { get; set; }
        public int VotosCandidato8 { get; set; }
        public int VotosCandidato9 { get; set; }
        public int VotosCandidato10 { get; set; }


        public bool AgregarResultado()
        {
            Voto_ElectronicoDataSetTableAdapters.ResultadosTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.ResultadosTableAdapter();
            try
            {
                mta.InsertQuery(Ganador, VotosCandidato1, VotosCandidato2, VotosCandidato3, VotosCandidato4, VotosCandidato5, VotosCandidato6, VotosCandidato7, VotosCandidato8, VotosCandidato9, VotosCandidato10);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Voto_ElectronicoDataSet.ResultadosDataTable ListaResultados()
        {
            Voto_ElectronicoDataSetTableAdapters.ResultadosTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.ResultadosTableAdapter();
            Voto_ElectronicoDataSet mds = new Voto_ElectronicoDataSet();


            try
            {
                mta.Fill(mds.Resultados);
                return mds.Resultados;
            }
            catch { return mds.Resultados; }
        }




    }
}
