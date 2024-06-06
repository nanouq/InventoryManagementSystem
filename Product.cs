using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Price
        {
            get
            {
                return price.ToString("C");
            }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(int productId, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productId;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Min = min;
            Max = max;
        }

        //Adds a part to associated parts list.
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        //Removes a part from associated parts list.
        //Returns true if a part was succesfully removed, returns false if no part was found.
        public bool removeAssociatedPart(int partId)
        {
            bool wasRemoved = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partId)
                {
                    AssociatedParts.Remove(part);
                    return wasRemoved = true;
                }
                else
                {
                    wasRemoved = false;
                }
            }
            return wasRemoved;
        }

        //Looks up part in associated parts list and returns a part if found.
        //If no part is found, returns an empty part.
        public Part lookupAssociatedPart(int partId)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partId)
                {
                    return part;
                }
            }
            Part noMatch = new InHouse();
            return noMatch;
        }
    }
}
