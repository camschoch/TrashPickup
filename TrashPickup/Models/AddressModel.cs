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
        public int ID { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string HomeAddress { get; set; }
        public string StateID { get; set; }

    }
    public class States
    {
        [Key]
        public int ID { get; set; }
        public string State { get; set; }
        public string StateAbriviation { get; set; }
    }
}