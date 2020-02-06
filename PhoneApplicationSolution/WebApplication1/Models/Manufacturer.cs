using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerID { get; set; }
        public string ManufacturerName { get; set; }
        public string URL { get; set; }
        public DateTime DateReleased { get; set; }
        public DateTime Founded { get; set; }

        public ICollection<Phone> PhoneList { get; set; }

        public Manufacturer()
        {
        }
    }
}