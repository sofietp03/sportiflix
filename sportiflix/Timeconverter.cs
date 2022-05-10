using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportiflix
{
    internal class Timeconverter
    {

        public static int HourToMinutes (int hour, int minuts)
        {
            return hour * 3600 + minuts * 60;
        }

        public static int MinutesAndSecounds(int minuts,int secounds)
        {
            return secounds + minuts * 60;
        }
    }
}
