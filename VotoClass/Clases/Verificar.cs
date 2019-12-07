using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotoClass.Clases
{
    public class Verificar
    {
        public TimeSpan EdadSpan { get; set; }
        public int Votos { get; set; }


        public bool EdadVerificacion(DateTime mDate)
        {
            EdadSpan = DateTime.Today.Subtract(mDate);
            if (EdadSpan.TotalDays < (365 * 18))
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }

        public bool GuardarVoto(int cedula)
        {
            Clases.Candidatos mCandidatos = new Candidatos();
            mCandidatos.Cedula = cedula;
            if (mCandidatos.SearchCandidatos())
            {
                Votos = mCandidatos.Votos;
                Votos = Votos+1;
                mCandidatos.Votos = Votos;
                if (mCandidatos.ActualizarCandidato())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
            
            

            
            
        }

    }
}
