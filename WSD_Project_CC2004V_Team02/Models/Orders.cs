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
        public string Customer_Name { get; set; }
        public string Customer_ID { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Delivery_Address { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Delivery_Date { get; set; }
        public TimeSpan Delivery_Time { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Order_Date { get; set; }        
    }
}
