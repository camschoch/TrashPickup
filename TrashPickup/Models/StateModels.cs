using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class States
    {
        [Key]
        public int ID { get; set; }
        public string State { get; set; }
        public string StateAbriviation { get; set; }
    }
}