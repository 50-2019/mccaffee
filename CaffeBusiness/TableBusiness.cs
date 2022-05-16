using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaffeeData;
using CaffeeData.Models;
namespace CaffeBusiness
{
    public class TableBusiness
    {
        private readonly TableRepository tableRepository = new TableRepository();

        public List<Table> getAllTables()
        {
            List<Table> tables = tableRepository.GetAllTables();
            return tables;

        }
        public bool insertTable(Table t)
        {
            return tableRepository .InsertTable(t) != 0;
        }
 
        public bool updateTable(int table_num, int pos_w, int pos_h)
        {
            return tableRepository.UpdatePosition(table_num, pos_w, pos_h) != 0;
        }

        public bool changeOccupancy(int table_num, bool occupied)
        {
            return tableRepository.ChangeOccupancy(table_num, occupied) != 0;
        }

        public bool deleteTable(int tableNum)
        {
            return tableRepository.DeleteTable(tableNum) != 0;  
        }
    }
}
