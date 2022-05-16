using CaffeeData;
using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeBusiness
{
    public class ItemBusiness
    {

        private readonly ItemRepository itemRepository = new ItemRepository();

        public List<Item> getAllItems()
        {
            List<Item> items = itemRepository.GetAllItems();
            return items;
        }
        
        public bool insertItem(Item i)
        {
            return itemRepository.InsertItem(i) != 0;
        }
        
        public bool updatePrice(int id, decimal price, string name)
        {
            return itemRepository.UpdatePriceAndName(id,price,name) != 0;
        }
        public bool deleteItem(int id)
        {
            return itemRepository.DeleteItem(id) != 0;      
        }
        public int GetIdOfItemName(string itemName)
        {
            return itemRepository.GetIdOfNameItem(itemName);
        }
        public decimal GetPriceOfItemByName(int itemId)
        {
            return itemRepository.GetPriceOfItemById(itemId);
        }
    }
}
