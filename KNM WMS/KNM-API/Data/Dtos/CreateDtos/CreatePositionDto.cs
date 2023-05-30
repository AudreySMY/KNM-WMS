using KNM_API.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace KNM_API.Data.Dtos.CreateDtos
{
    public class CreatePositionDto
    {

        public string IdentifierPos { get; set; }
        public float VolumeMax { get; set; }
        public int EanID { get; set; }

    }
}
