using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class InHouse : Part
    {
        private int machineID;
        public int MachineID { get; set; }
        public InHouse() { }
        public InHouse(int partID, string name, decimal price,int inStock, int min, int max)
        {
            PartID= partID;
            Name= name;
            Price= price.ToString();
            InStock = inStock;
            Min= min;
            Max= max;
        }
        public InHouse(int partID, string name, decimal price,int inStock, int min, int max, int machID)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machID;
        }
    }
}
