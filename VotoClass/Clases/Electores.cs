using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotoClass.Clases
{
   public class Electores
    {
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string ProblemasJudiciales { get; set; }
        public int Cedula { get; set; }

        public bool AgregarElector()
        {
            Voto_ElectronicoDataSetTableAdapters.ElectoresTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.ElectoresTableAdapter();
            try
            {
                mta.InsertQuery(Nombre, PrimerApellido, SegundoApellido,FechaNacimiento,ProblemasJudiciales,Cedula);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool ActualizarElector()
        {
            Voto_ElectronicoDataSetTableAdapters.ElectoresTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.ElectoresTableAdapter();
            try
            {
                mta.UpdateQuery(Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, ProblemasJudiciales, Cedula);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool EliminarElector()
        {
            Voto_ElectronicoDataSetTableAdapters.ElectoresTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.ElectoresTableAdapter();
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


        public Voto_ElectronicoDataSet.ElectoresDataTable ListaElectores()
        {
            Voto_ElectronicoDataSetTableAdapters.ElectoresTableAdapter mta = new Voto_ElectronicoDataSetTableAdapters.ElectoresTableAdapter();
            Voto_ElectronicoDataSet mds = new Voto_ElectronicoDataSet();


            try
            {
                mta.Fill(mds.Electores);
                return mds.Electores;
            }
            catch { return mds.Electores; }
        }



    }
}
