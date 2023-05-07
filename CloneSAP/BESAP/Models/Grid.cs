using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BESAP.Models
{
    public class Grid
    {
        public Grid(string collorCod, string sizeCod)
        {
            this.collorCod = collorCod;
            this.sizeCod = sizeCod; 
        }

        public string collorCod { get; set; }   
        public string sizeCod { get; set; } 
    }
}
