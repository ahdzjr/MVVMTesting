using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class VehicleModel
    {
        [Key]
        public int VehicleId { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        [NotMapped]
        public string FullVehicle
        {
            get
            {
                return $"{ Make } { Model } { Year }";
            }
        }
    }
}
