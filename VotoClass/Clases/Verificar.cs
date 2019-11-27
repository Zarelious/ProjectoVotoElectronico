using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotoClass.Clases
{
    class Verificar
    {
        public TimeSpan EdadSpan { get; set; }

        public bool EdadVerificacion(DateTime mDate)
        {
            EdadSpan = mDate.Subtract(DateTime.Today);
            if (EdadSpan.TotalDays < (365 * 18))
            {
                return false;
            }
            else
            {
                return true;
            }

            // LateFee = Convert.ToInt16(EdadSpan.TotalDays) * (mcost + (mcost * (10 / 100)));
        }


    }
}
