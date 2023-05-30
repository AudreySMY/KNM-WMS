using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script
{
    internal class Position
    {
        public string IdentifierPos { get; set; }
        public float VolumeMax { get; set; }
        public int EanID { get; set; }

        public Position(string identifierPos, float volumeMax, int eanID)
        {
            IdentifierPos = identifierPos;
            VolumeMax = volumeMax;
            EanID = eanID;
        }
    }
}
