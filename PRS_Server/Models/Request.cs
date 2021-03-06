using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRS_Server.Models
{
    public class Request
    {
       public int Id { get; set; }

        [Required, StringLength(80)]
        public string Description { get; set; }

        [Required, StringLength(80)]
        public string Justification { get; set; }

        [StringLength(80)]
        public string RejectionReason { get; set; }

        [Required, StringLength(20)]
        public string DeliveryMode { get; set; } = "Pickup";

        [Required, StringLength(10)]
        public string Status { get; set; } = "NEW";

        [Required, Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; } = 0;
        public virtual User User { get; set; }
        public int UserId { get; set; }

        public virtual List<RequestLine> RequestLines { get; set; }  //Is this right??


        //default constructor
        public Request() { }
    }
}
