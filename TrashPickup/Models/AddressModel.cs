using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class AddressModel
    {
        [Key]
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string HomeAddress { get; set; }

    }
}