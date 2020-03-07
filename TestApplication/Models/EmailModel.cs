using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class EmailModel
    {
        [Key]
        public int EmailId { get; set; }
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
    }
}
