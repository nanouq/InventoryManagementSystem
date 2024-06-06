using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Outsourced : Part
    {
        private string companyName;
        public string CompanyName { get;set; }
        public Outsourced() { }
        public Outsourced(int partID, string name,decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string compName)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = compName;
        }
    }
}
