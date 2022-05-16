using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaffeeData;
using CaffeeData.Models;
namespace CaffeBusiness
{
    public class OrderItemBusiness
    {
        private readonly OrderItemRepository orderItemRepository = new OrderItemRepository();
        
        public bool insertOrderItem(OrderItem o)
        {
            return orderItemRepository.InsertOrderItem(o) != 0;
        }

    }
}
