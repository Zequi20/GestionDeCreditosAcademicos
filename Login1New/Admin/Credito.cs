using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1New.Admin
{
    public class Credito
    {
        public int credito=0;
        public int residuo = 0;
        public void calcular(int horasHechas,int horaCredito)
        {
            residuo = horasHechas % horaCredito;
            credito = Int32.Parse((horasHechas / horaCredito).ToString().Split('.')[0]);
        }
        public void calcularAyudantia(int horasHechas, int semanas)
        {
            residuo = (horasHechas % semanas);
            credito = Int32.Parse((horasHechas / semanas).ToString().Split('.')[0]);
        }
    }
}
