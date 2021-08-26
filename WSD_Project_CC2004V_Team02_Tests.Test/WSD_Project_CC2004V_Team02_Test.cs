using System;
using System.Collections.Generic;
using System.Text;
using WSD_Project_CC2004V_Team02.Models;
using Xunit;

namespace WSD_Project_CC2004V_Team02_Tests.Test
{
    public class WSD_Project_CC2004V_Team02_Test
    {
        [Fact]
        public void ChangeCustomerName()
        {
            var orderDetail = new Orders { Customer_Name = "Marcus Lee", Description = "Fish and Chips", Quantity = 70 };

            orderDetail.Customer_Name = "Sam Jackson";

            Assert.Equal("Sam Jackson", orderDetail.Customer_Name);
        }

        [Fact]
        public void ChangeDescription()
        {
            var orderDetail = new Orders { Customer_Name = "Marcus Lee", Description = "Fish and Chips", Quantity = 70 };

            orderDetail.Description = "Fish and Chips";

            Assert.Equal("Fish and Chips", orderDetail.Description);
        }

        [Fact]
        public void ChangeQuantity()
        {
            var orderDetail = new Orders { Customer_Name = "Marcus Lee", Description = "Fish and Chips", Quantity = 70 };

            orderDetail.Quantity = 70;

            Assert.Equal(70, orderDetail.Quantity);
        }
    }
   
        
    
}
