using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Busses
{
    class Bus
    {
        public static List<Bus> busses = new List<Bus>();

        public string name;
        public Station[] stations;

        public Bus(string name, Station[] stations)
        {
            this.name = name;
            this.stations = stations;

            busses.Add(this);
        }
    }
}
