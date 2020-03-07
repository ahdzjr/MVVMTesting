using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class CustomerModel
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmailModel EmailAddress { get; set; }
        public virtual List<AddressModel> Addresses { get; set; }
        public virtual List<VehicleModel> Vehicles { get; set; }
        public virtual List<AppointmentModel> Appointments { get; set; }
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
