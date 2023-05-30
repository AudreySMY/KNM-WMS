using KNMLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script
{
    internal class Ean
    {
        public int EanID { get; set; }


        public string ModelId { get; set; }
        public Model Model { get; set; }


        public string GridId { get; set; }
        public Grid Grid { get; set; }
        public Ean(Grid grid, Model model)
        {
            Grid = grid;
            Model = model;
        }
    }
}
