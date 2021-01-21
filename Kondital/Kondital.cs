using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondital
{
    public class Kondital
    {
        /// <summary>
        /// udregner kondital
        /// </summary>
        /// <param name="_hvilepuls">Pulsen er slag pr. minut. (fx 80)</param>
        /// <param name="_makspuls">Pulsen er slag pr. minut. (fx 120)</param>
        /// <returns>Kondital ud fra de to give værdier</returns>
        public static double BeregnKondital(double _hvilepuls, double _makspuls)
        {
            double kondital = (_makspuls / _hvilepuls) * 15.3;
            return Math.Round(kondital);
        }
        /// <summary>
        /// Udregner Ilt optagelse 
        /// </summary>
        /// <param name="kondital">Det kondital som personen nu måtte have.</param>
        /// <param name="vaegt">Vægten på person</param>
        /// <returns>Sender et double tal tilbage med et dicimatal </returns>
        public static double BeregnIltoptagelse(double kondital, int vaegt)
        {
            return Math.Round( (kondital * vaegt) / 1000 , 1);
        }
    }
}
