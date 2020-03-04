using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class AddressModel
    {

        public int AddressId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string FullAddress 
        {
            get
            {
                return $"{ AddressLine1 }, { AddressLine2 }, { City }, { State } { Zip }";
            }
        }
    }
}
