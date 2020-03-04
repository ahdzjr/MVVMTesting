using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class AppointmentModel
    {

        public int AppointmentId { get; set; }

        public string Job { get; set; }

        public string Details { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public CustomerModel Customer { get; set; }

        public VehicleModel Vehicle { get; set; }

    }
}
