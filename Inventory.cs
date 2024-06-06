using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        int currentIndex;

        //Adds product to product list.
        public static void addProduct(Product prod)
        {
            Products.Add(prod);
        }

        //Removes product from product list.
        //Returns true if a part was deleted and false if not.
        public static bool removeProduct(int prodID)
        {
            bool wasDeleted = false;
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    Products.Remove(prod);
                    return wasDeleted = true;
                }
                else
                {
                    wasDeleted = false;
                }
            }
            return wasDeleted;
        }

        //Look up a product from product list, returns a product if a matching ID is found, returns an empty product if not.
        //Returns a product if found, returns an empty product if not.
        public static Product lookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }
            }
            Product noMatch = new Product();
            return noMatch;
        }

        //Updates a product from the product list.
        public static void updateProduct(int prodID, Product prod)
        {
            foreach (Product prd in Products)
            {
                if (prd.ProductID == prodID)//removes old part and inserts new one in previous location in list
                {
                    Products.Insert(Products.IndexOf(prd), prod);
                    Products.RemoveAt(Products.IndexOf(prd));
                    return;
                }
            }
            return;
        }

        //Adds part to parts list.
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        //Deletes part from parts list.
        //Returns true if a part was found, returns false if not.
        public static bool deletePart(Part part)
        {
            bool wasDeleted = false;
            foreach(Part prt in AllParts)
            {
                if (prt.PartID == part.PartID)
                {
                    AllParts.Remove(prt);
                    return wasDeleted = true;
                }
                else
                {
                    wasDeleted = false;
                }
            }
            return wasDeleted;
        }

        //Looks up part from part list, returns a part if a matching ID is found, returns an empty part if not.
        //Returns part if found and returns an empty part if not.
        public static Part lookupPart(int partID)
        {
            foreach(Part part in AllParts)
            {
                if(part.PartID == partID)
                {
                    return part;
                }
            }
            Part noMatch = new InHouse();
            return noMatch;
        }

        //Update part in part list.
        public static void updatePart(int partID, Part part)
        {
            foreach(Part prt in AllParts)
            {
                if(prt.PartID == partID)//removes old part and inserts new one in previous location in list
                {
                    AllParts.Insert(AllParts.IndexOf(prt), part);
                    AllParts.RemoveAt(AllParts.IndexOf(prt));
                    return;
                }
            }
            return;
        }

        //Populate part and product lists with dummy data for testing.
        public static void populateLists()
        {
            //Initialize example products.
            Product testProduct1 = new Product(1, "Red Bicycle", 5.0m, 20, 5, 20);
            Product testProduct2 = new Product(2, "Yellow Bicycle", 10.0m, 5, 1, 10);
            Product testProduct3 = new Product(3, "Blue Bicycle", 20.0m, 10, 5, 50);

            //Add example products to list.
            Products.Add(testProduct1);
            Products.Add(testProduct2);
            Products.Add(testProduct3);

            //Initialize example In-house parts.
            Part testInPart1 = new InHouse(1, "Wheel", 5.5m, 50, 1, 100, 1);
            Part testInPart2 = new InHouse(2, "Pedal", 11.0m,10,  5, 50, 2);

            //Initialize example Outsourced parts.
            Part testOutPart1 = new Outsourced(3, "Chain", 23.0m, 49, 1, 50, "Company 1");
            Part testOutPart2 = new Outsourced(4, "Seat", 7.5m, 20, 1, 100, "Company 2");

            //Add example parts to list.
            AllParts.Add(testInPart1);
            AllParts.Add(testInPart2);
            AllParts.Add(testOutPart1);
            AllParts.Add(testOutPart2);
        }
    }
}
