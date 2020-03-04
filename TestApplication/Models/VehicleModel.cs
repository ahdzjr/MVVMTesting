using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class VehicleModel
    {

        public int VehicleId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public AppointmentModel LastAppointment { get; set; }

        public string FullVehicle
        {
            get
            {
                return $"{ Make } { Model } { Year }";
            }
        }
    }
}
