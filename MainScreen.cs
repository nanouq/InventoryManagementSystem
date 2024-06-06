using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            if(Inventory.AllParts.Count== 0 && Inventory.Products.Count == 0)
            {
                Inventory.populateLists();
            }
            
            var partsTable = new BindingSource();
            partsTable.DataSource = Inventory.AllParts;
            partsGridView.DataSource = partsTable; 

            var productTable = new BindingSource();
            productTable.DataSource = Inventory.Products;
            productsGridView.DataSource = productTable;
            partsGridView.ClearSelection();
            productsGridView.ClearSelection();
        }   

        private void MainScreen_Load(object sender, EventArgs e)
        {
            partsGridView.ClearSelection();
            productsGridView.ClearSelection();
        }

        //Opens add part screen.
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            new AddPartScreen().ShowDialog();
        }

        //Checks selection type and opens modify part screen.
        private void btnModPart_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (partsGridView.SelectedRows.Count != 0)
            {
                if (partsGridView.CurrentRow.DataBoundItem.GetType() == typeof(InventoryManagementSystem.InHouse))
                {
                    InHouse inhouse = (InHouse)partsGridView.CurrentRow.DataBoundItem;
                    new ModifyPartScreen(inhouse).ShowDialog();
                }
                else
                {
                    Outsourced outsourced = (Outsourced)partsGridView.CurrentRow.DataBoundItem;
                    new ModifyPartScreen(outsourced).ShowDialog();
                }
            }
            else
            {
                result = MessageBox.Show("Please pick a part to modify.");
            }    
        }

        //Opens add product screen.
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            new AddProductScreen().ShowDialog();
        }

        //Checks selection and opens modify product screen.
        private void btnModProd_Click(object sender, EventArgs e)
        {
            if (productsGridView.SelectedRows.Count != 0)
            {
                Product prod = (Product)productsGridView.CurrentRow.DataBoundItem;
                new ModifyProductScreen(prod).ShowDialog();
            }
            else
            {
                MessageBox.Show("Please pick a part to modify.");
            }
        }

        //Exits the program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Checks part to delete and deletes it if valid.
        private void btnDelPart_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if(partsGridView.SelectedRows.Count != 0)
            {
                result = MessageBox.Show("Are you sure you want to delete this part?", "", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Inventory.deletePart((Part)partsGridView.CurrentRow.DataBoundItem);
                    partsGridView.Refresh();
                }
                else
                {
                    return;
                }                 
            }
            else
            {
                result = MessageBox.Show("Please pick a part to delete.");
            }

            partsGridView.ClearSelection();
        }

        //Checks search box input and finds part either by name, or by id.
        private void btnSearchPart_Click(object sender, EventArgs e)
        {
            partsGridView.ClearSelection();
            int number;
            if (txtSearchPart.Text.Length > 0)
            {
                if (!Int32.TryParse(txtSearchPart.Text, out number))//search by name
                {
                    //search for first instance of text 
                    foreach(Part part in Inventory.AllParts)
                    {
                        if (part.Name.ToLower().Contains(txtSearchPart.Text.ToLower()))
                        {
                            foreach (DataGridViewRow row in partsGridView.Rows)
                            {
                                Part partRow = (Part)row.DataBoundItem;
                                if (partRow.PartID == part.PartID)
                                {
                                    row.Selected = true;
                                    break;
                                }
                                else
                                {
                                    row.Selected = false;
                                }
                            }
                            break;
                        }
                    }
                    
                }
                else //search by ID
                {
                    Part found = Inventory.lookupPart(int.Parse(txtSearchPart.Text));
                    foreach(DataGridViewRow row in partsGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if(part.PartID == found.PartID)
                        {
                            row.Selected= true;
                            break;
                        }
                        else
                        {
                            row.Selected= false;
                        }
                    }
                }
            }
            else
            {
                partsGridView.ClearSelection();
                return;
            }
        }

        //Checks product to delete and deletes it if valid.
        private void btnDelProd_Click(object sender, EventArgs e)
        {
            if (productsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please pick a product to delete.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?","", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Product prod = (Product)productsGridView.CurrentRow.DataBoundItem;
                    if(prod.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("Cannot delete a product with an associated part. Please remove associated parts and try again.");
                        return;
                    }
                    else
                    {
                        Inventory.removeProduct(prod.ProductID);
                        partsGridView.Refresh();
                    }
                }
            }
            productsGridView.ClearSelection();
            
        }

        //Checks search box input and finds product either by name, or by id.
        private void btnSearchProd_Click(object sender, EventArgs e)
        {
            productsGridView.ClearSelection();
            int number;
            if (txtSearchProduct.Text.Length > 0)
            {
                if (!Int32.TryParse(txtSearchProduct.Text, out number))//search by name
                {
                    //search for first instance of text 
                    foreach (Product prod in Inventory.Products)
                    {
                        if (prod.Name.ToLower().Contains(txtSearchProduct.Text.ToLower()))
                        {
                            foreach (DataGridViewRow row in productsGridView.Rows)
                            {
                                Product prodRow = (Product)row.DataBoundItem;
                                if (prodRow.ProductID == prod.ProductID)
                                {
                                    row.Selected = true;
                                    break;
                                }
                                else
                                {
                                    row.Selected = false;
                                }
                            }
                            break;
                        }                      
                    }

                }
                else //search by ID
                {
                    Product found = Inventory.lookupProduct(int.Parse(txtSearchProduct.Text));
                    foreach (DataGridViewRow row in productsGridView.Rows)
                    {
                        Product prod = (Product)row.DataBoundItem;
                        if (prod.ProductID == found.ProductID)
                        {
                            row.Selected = true;
                            break;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
            }
            else
            {
                productsGridView.ClearSelection();
                return;
            }
        }
    }
}
