using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSD_Project_CC2004V_Team02.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTime Delivery_Date { get; set; }
        public DateTime Order_Date { get; set; }        
    }
}
