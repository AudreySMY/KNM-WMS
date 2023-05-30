using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script
{
    internal class Model
    {
        public string ModelCod { get; set; }
        public float Volume { get; set; }
        public Model(string marca, string modelnbr,float volume)
        {
            Volume = volume;
            ModelCod = marca+modelnbr;
        }
    }
}
