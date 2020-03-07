using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication
{
    public class DataContext : DbContext
    {
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<VehicleModel> Vehicles { get; set; }
        public DbSet<EmailModel> EmailAddresses { get; set; }
        public DbSet<AppointmentModel> Appointments { get; set; }

    }
}
