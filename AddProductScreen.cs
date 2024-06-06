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
    public partial class AddProductScreen : Form
    {
        ErrorProvider nameErr = new ErrorProvider();
        ErrorProvider invErr = new ErrorProvider();
        ErrorProvider priceErr = new ErrorProvider();
        ErrorProvider minErr = new ErrorProvider();
        ErrorProvider maxErr = new ErrorProvider();
        int number;
        BindingList<Part> addedParts = new BindingList<Part>();
        public AddProductScreen()
        {
            InitializeComponent();
            gridAddProductAllCandidateParts.DataSource = Inventory.AllParts;
            gridAddProductAssociatedParts.DataSource = addedParts;
            txtAddProductID.Text = (Inventory.Products.Last().ProductID + 1).ToString();
        }

        //Checks if all fields are filled out. If so, enables the use of the save button.
        private void checkIfComplete()
        {
            if (txtAddProductName.BackColor != Color.Salmon && txtAddProductInventory.BackColor != Color.Salmon && txtAddProductPrice.BackColor != Color.Salmon && txtAddProductMin.BackColor != Color.Salmon && txtAddProductMax.BackColor != Color.Salmon)
            {
                btnAddProductSave.Enabled = true;
            }
            else
            {
                btnAddProductSave.Enabled = false;
            }
        }

        //Clears selected items in gridviews when add product screen is loaded.
        private void AddProductScreen_Load(object sender, EventArgs e)
        {
            gridAddProductAllCandidateParts.ClearSelection();
            gridAddProductAssociatedParts.ClearSelection();
        }

        //Validates product name input.
        private void txtAddProductName_TextChanged(object sender, EventArgs e)
        {
            //if pproduct name is empty, flag an error
            if (string.IsNullOrEmpty(txtAddProductName.Text))
            {
                txtAddProductName.BackColor = Color.Salmon;
                nameErr.SetError(txtAddProductName, "Product name required");
            }
            else
            {
                txtAddProductName.BackColor = Color.White;
                nameErr.Clear();
            }
            checkIfComplete();
        }

        //Validates product inventory input.
        private void txtAddProductInventory_TextChanged(object sender, EventArgs e)
        { 
            //if inventory is empty, flag an error
            if (string.IsNullOrEmpty(txtAddProductInventory.Text))
            {
                txtAddProductInventory.BackColor = Color.Salmon;

                invErr.SetError(txtAddProductInventory, "Inventory required");
            }
            else if (!Int32.TryParse(txtAddProductInventory.Text, out number)) //if inventory is not a number, flag an error
            {
                txtAddProductInventory.BackColor = Color.Salmon;

                invErr.SetError(txtAddProductInventory, "Inventory must be numeric");
            }
            else
            {
                txtAddProductInventory.BackColor = Color.White;
                invErr.Clear();
            }
            checkIfComplete();
        }

        //Validates product price input.
        private void txtAddProductPrice_TextChanged(object sender, EventArgs e)
        {
            decimal number2;
            //if price is empty, flag an error
            if (string.IsNullOrEmpty(txtAddProductPrice.Text))
            {
                txtAddProductPrice.BackColor = Color.Salmon;

                priceErr.SetError(txtAddProductPrice, "Price required");
            }
            else if (!Decimal.TryParse(txtAddProductPrice.Text, out number2)) //if price is not a number, flag an error
            {
                txtAddProductPrice.BackColor = Color.Salmon;

                priceErr.SetError(txtAddProductPrice, "Price must be numeric");
            }
            else
            {
                txtAddProductPrice.BackColor = Color.White;
                priceErr.Clear();
            }
            checkIfComplete();
        }

        //Validates product max input.
        private void txtAddProductMax_TextChanged(object sender, EventArgs e)
        {
            //if max is empty, flag an error
            if (string.IsNullOrEmpty(txtAddProductMax.Text))
            {
                txtAddProductMax.BackColor = Color.Salmon;
                maxErr.SetError(txtAddProductMax, "Max required");
            }
            else if (!Int32.TryParse(txtAddProductMax.Text, out number)) //if max is not a number, flag an error
            {
                txtAddProductMax.BackColor = Color.Salmon;

                maxErr.SetError(txtAddProductMax, "Max must be numeric");
            }
            else
            {
                txtAddProductMax.BackColor = Color.White;
                maxErr.Clear();
            }
            checkIfComplete();
        }

        //Validates product min input.
        private void txtAddProductMin_TextChanged(object sender, EventArgs e)
        {
            //if min is empty, flag an error
            if (string.IsNullOrEmpty(txtAddProductMin.Text))
            {
                txtAddProductMin.BackColor = Color.Salmon;
                minErr.SetError(txtAddProductMin, "Min required");
            }
            else if (!Int32.TryParse(txtAddProductMin.Text, out number)) //if min is not a number, flag an error
            {
                txtAddProductMin.BackColor = Color.Salmon;
                minErr.SetError(txtAddProductMin, "Min must be numeric");
            }
            else
            {
                txtAddProductMin.BackColor = Color.White;
                minErr.Clear();
            }
            checkIfComplete();
        }

        //Validates all values and adds product to inventory.
        private void btnAddProductSave_Click(object sender, EventArgs e)
        {
            string name = txtAddProductName.Text;
            decimal price = decimal.Parse(txtAddProductPrice.Text);
            int instock = int.Parse(txtAddProductInventory.Text);
            int min = int.Parse(txtAddProductMin.Text);
            int max = int.Parse(txtAddProductMax.Text);
            
            if (min > max)
            {
                MessageBox.Show("Minimum cannot be greater than the maximum.");
                return;
            }
            else if (instock > max || instock < min)
            {
                MessageBox.Show("Inventory must be between min and max values.");
                return;
            }
            else
            {
                Product prod = new Product((Inventory.Products.Last().ProductID + 1), name, price, instock, min, max);
                Inventory.addProduct(prod);

                foreach (Part part in addedParts)
                {
                    prod.addAssociatedPart(part);
                }
            }
            Close();
        }

        //Adds parts to associated parts grid.
        private void btnAddProductAdd_Click(object sender, EventArgs e)
        {
            Part addedPart = (Part)gridAddProductAllCandidateParts.CurrentRow.DataBoundItem;
            addedParts.Add(addedPart);
            gridAddProductAssociatedParts.Update();
            gridAddProductAssociatedParts.ClearSelection();
        }

        //Removes part from associated parts grid.
        private void btnAddProductDelete_Click(object sender, EventArgs e)
        {
            Part prt = (Part)gridAddProductAssociatedParts.CurrentRow.DataBoundItem;
            DialogResult result;

            if (gridAddProductAssociatedParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please pick a part to delete.");
            }
            else
            {
                result = MessageBox.Show("Are you sure you want to delete this part?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    addedParts.Remove(prt);
                }
                else
                {
                    return;
                }
            }
        }

        //Closes add product screen and returns to the main screen.
        private void btnAddProductCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Checks search box input and finds product either by name, or by id.
        private void btnAddProductSearch_Click(object sender, EventArgs e)
        {
            gridAddProductAllCandidateParts.ClearSelection();
            if (txtAddProductSearch.Text.Length > 0)
            {
                if (!Int32.TryParse(txtAddProductSearch.Text, out number))//search by name
                {
                    //search for first instance of text 
                    foreach (Part part in Inventory.AllParts)
                    {
                        if (part.Name.ToLower().Contains(txtAddProductSearch.Text.ToLower()))
                        {
                            gridAddProductAllCandidateParts.Rows[part.PartID - 1].Selected = true;
                            break;
                        }
                    }

                }
                else //search by ID
                {
                    Part found = Inventory.lookupPart(int.Parse(txtAddProductSearch.Text));
                    foreach (DataGridViewRow row in gridAddProductAllCandidateParts.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.PartID == found.PartID)
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
                gridAddProductAllCandidateParts.ClearSelection();
                return;
            }
        }
    }
}
