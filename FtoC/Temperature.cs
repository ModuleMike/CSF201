using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    public class Temperature
    {
        private double _kelvinTemp;
        public double Kelvin
        {
            get { return _kelvinTemp; }
            set
            {
                if (value < 0)
                {
                    _kelvinTemp = 0;
                }
                else
                {
                    _kelvinTemp = value;
                }
            }
        }

        public double Celsius
        {
            get
            {
                return Kelvin - 273.15;
            }
        }

        public double Fahrenheit
        {
            get
            {
                return Celsius * 9 / 5 + 32;
            }
        }

    }
}
