using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNMLib.Models
{
    public class StockID
    {

        public int EanID { get; set; }


        public string ModelId { get; set; }
        public  Model Model { get; set; }


        public string GridId { get; set; }
        public Grid Grid { get; set; }



    }
}
