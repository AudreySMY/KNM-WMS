using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BESAP.Models
{
    public class Material
    {
        public Material(string material, float volume)
        {
            this.material = material;
            this.volume = volume;
        }

        public string material { get; set; }    
        public float volume { get; set; }   
    }
}
