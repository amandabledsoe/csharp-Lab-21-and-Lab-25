using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_21_Movie_Registration.Models
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public int MovieSelectionID { get; set; }

        //[NotMapped]
        //[ForeignKey("MovieSelectionID")]
        //public virtual MovieSelection MovieSelection { get; set; }
        public string UserSessionID { get; set; }
    }
}
