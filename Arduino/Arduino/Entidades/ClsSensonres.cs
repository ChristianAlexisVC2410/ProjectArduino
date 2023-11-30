using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arduino.Entidades
{
    public class ClsSensonres
    {
        public double Temperatura { get; set; }
        public bool EstatusHum { get; set; }
        public double TemperaturaTeclado { get; set; }
        public string strTem { get; set; }
        public string strHum { get; set; }
        public string strTemTeclado { get; set; }

        public void obtenerValores()
        {
            int humedadAux = 0;
            try
            {
                this.Temperatura = Convert.ToDouble(strTem);
                humedadAux = Convert.ToInt16(strHum);
                this.EstatusHum = Convert.ToBoolean(humedadAux);
                this.TemperaturaTeclado = Convert.ToDouble(strTemTeclado);
            }catch(Exception ex)
            {
              System.Windows.Forms.MessageBox.Show("No se pudo convertir los valores de tipo string");
            }
        }
    }
}
