using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaffeeData;
using CaffeeData.Models;
namespace CaffeBusiness
{
    public class BillBusiness
    {
        private readonly BillRepository billRepository = new BillRepository();
        private readonly OrderItemRepository orderItemRepository = new OrderItemRepository();
        public List<Bill> getAllBills()
        {
            List<Bill> bills = billRepository.GetAllBills();
            return bills;
        }
        public bool insertBill(Bill b)
        {
            return billRepository.InsertBill(b) != 0;
        }
    }
}
