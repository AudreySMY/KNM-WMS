using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPLib.Models
{
    public class StockID
    {

            public int stockIDn { get; set; }
            public int materialId { get; set; }
            public Material material { get; set; }
            public int gridId { get; set; }
            public Grid grid { get; set; }


    }
}
