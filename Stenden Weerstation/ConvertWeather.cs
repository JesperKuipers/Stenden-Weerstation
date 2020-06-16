using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stenden_Weerstation
{
    class ConvertWeather
    {


        public Weather[] weather { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public string name { get; set; }


        public class Main
        {
            public float temp { get; set; }
            public int humidity { get; set; }
        }

        public class Wind
        {
            public float speed { get; set; }

            public int deg { get; set; }
        }

        public class Weather
        {
            public string main { get; set; }
            public string icon { get; set; }
        }
    }
}
