using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Busses
{
    class Station
    {
        public static List<Station> stations = new List<Station>();

        public string name;
        public Location location;
        public List<Bus> busses;

        public Station(string name, Location location)
        {
            this.name = name;
            this.location = location;

            stations.Add(this);
        }

        public static void InitStations()
        {
            foreach(Station s1 in stations)
            {
                foreach(Bus bus in Bus.busses)
                {
                    if(bus.stations.Any(x => x == s1))
                    {
                        s1.busses.Add(bus);
                    }
                }
            }
        }
    }
}
