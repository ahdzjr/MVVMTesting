using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class CustomerModel
    {

        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public EmailModel EmailAddress { get; set; }

        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();

        public List<VehicleModel> Vehicles { get; set; } = new List<VehicleModel>();

        public List<AppointmentModel> Appointments { get; set; } = new List<AppointmentModel>();

        public AddressModel PrimaryAddress { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
    
}
