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
    public partial class ModifyProductScreen : Form
    {
        ErrorProvider nameErr = new ErrorProvider();
        ErrorProvider invErr = new ErrorProvider();
        ErrorProvider priceErr = new ErrorProvider();
        ErrorProvider minErr = new ErrorProvider();
        ErrorProvider maxErr = new ErrorProvider();
        int number;
        BindingList<Part> addedParts= new BindingList<Part>();
        public ModifyProductScreen(Product prod)
        {
            InitializeComponent();
            txtModifyProductID.Text = prod.ProductID.ToString();
            txtModifyProductName.Text = prod.Name.ToString();
            txtModifyProductInventory.Text = prod.InStock.ToString();
            txtModifyProductPrice.Text = prod.Price.Substring(1);
            txtModifyProductMax.Text = prod.Max.ToString();
            txtModifyProductMin.Text = prod.Min.ToString();

            gridModifyProductAllCandidateParts.DataSource = Inventory.AllParts;

            foreach(Part part in prod.AssociatedParts)
            {
                addedParts.Add(part);
            }
            gridModifyProductAssociatedParts.DataSource = addedParts;
        }

        //Checks if all fields are filled out. If so, enables the use of the save button.
        private void checkIfComplete()
        {
            if (txtModifyProductName.BackColor != Color.Salmon && txtModifyProductInventory.BackColor != Color.Salmon && txtModifyProductPrice.BackColor != Color.Salmon && txtModifyProductMin.BackColor != Color.Salmon && txtModifyProductMax.BackColor != Color.Salmon)
            {
                btnModifyProductSave.Enabled = true;
            }
            else
            {
                btnModifyProductSave.Enabled = false;
            }
        }

        //Validates product name input.
        private void txtModifyProductName_TextChanged(object sender, EventArgs e)
        {
            //if pproduct name is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyProductName.Text))
            {
                txtModifyProductName.BackColor = Color.Salmon;
                nameErr.SetError(txtModifyProductName, "Product name required");
            }
            else
            {
                txtModifyProductName.BackColor = Color.White;
                nameErr.Clear();
            }
            checkIfComplete();
        }

        //Validates product inventory input.
        private void txtModifyProductInventory_TextChanged(object sender, EventArgs e)
        {
            //if inventory is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyProductInventory.Text))
            {
                txtModifyProductInventory.BackColor = Color.Salmon;

                invErr.SetError(txtModifyProductInventory, "Inventory required");
            }
            else if (!Int32.TryParse(txtModifyProductInventory.Text, out number)) //if inventory is not a number, flag an error
            {
                txtModifyProductInventory.BackColor = Color.Salmon;

                invErr.SetError(txtModifyProductInventory, "Inventory must be numeric");
            }
            else
            {
                txtModifyProductInventory.BackColor = Color.White;
                invErr.Clear();
            }
            checkIfComplete();
        }

        //Validates product price input.
        private void txtModifyProductPrice_TextChanged(object sender, EventArgs e)
        {
            decimal number2;
            //if price is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyProductPrice.Text))
            {
                txtModifyProductPrice.BackColor = Color.Salmon;

                priceErr.SetError(txtModifyProductPrice, "Price required");
            }
            else if (!Decimal.TryParse(txtModifyProductPrice.Text, out number2)) //if price is not a number, flag an error
            {
                txtModifyProductPrice.BackColor = Color.Salmon;

                priceErr.SetError(txtModifyProductPrice, "Price must be numeric");
            }
            else
            {
                txtModifyProductPrice.BackColor = Color.White;
                priceErr.Clear();
            }
            checkIfComplete();
        }

        //Validates product max input.
        private void txtModifyProductMax_TextChanged(object sender, EventArgs e)
        {
            //if max is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyProductMax.Text))
            {
                txtModifyProductMax.BackColor = Color.Salmon;
                maxErr.SetError(txtModifyProductMax, "Max required");
            }
            else if (!Int32.TryParse(txtModifyProductMax.Text, out number)) //if max is not a number, flag an error
            {
                txtModifyProductMax.BackColor = Color.Salmon;

                maxErr.SetError(txtModifyProductMax, "Max must be numeric");
            }
            else
            {
                txtModifyProductMax.BackColor = Color.White;
                maxErr.Clear();
            }
            checkIfComplete();
        }

        //Validates product min input.
        private void txtModifyProductMin_TextChanged(object sender, EventArgs e)
        {
            //if min is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyProductMin.Text))
            {
                txtModifyProductMin.BackColor = Color.Salmon;
                minErr.SetError(txtModifyProductMin, "Min required");
            }
            else if (!Int32.TryParse(txtModifyProductMin.Text, out number)) //if min is not a number, flag an error
            {
                txtModifyProductMin.BackColor = Color.Salmon;
                minErr.SetError(txtModifyProductMin, "Min must be numeric");
            }
            else
            {
                txtModifyProductMin.BackColor = Color.White;
                minErr.Clear();
            }
            checkIfComplete();
        }

        //Validates all values and updates product in inventory.
        private void btnModifyProductSave_Click(object sender, EventArgs e)
        {
            string name = txtModifyProductName.Text;
            decimal price = decimal.Parse(txtModifyProductPrice.Text);
            int instock = int.Parse(txtModifyProductInventory.Text);
            int min = int.Parse(txtModifyProductMin.Text);
            int max = int.Parse(txtModifyProductMax.Text);

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
                Product prod = new Product(int.Parse(txtModifyProductID.Text), name, price, instock, min, max);
                Inventory.updateProduct(prod.ProductID, prod);

                foreach (Part part in addedParts)
                {
                    prod.addAssociatedPart(part);
                }
            }
            Close();
        }

        //Confirms selected part to delete and removes part from associated parts if valid.
        private void btnModifyProductDelete_Click(object sender, EventArgs e)
        {
            Part prt = (Part)gridModifyProductAssociatedParts.CurrentRow.DataBoundItem;
            DialogResult result;
            
            if (gridModifyProductAssociatedParts.SelectedRows.Count == 0)
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

        //Confirms selected part to add and adds part to associated parts.
        private void btnModifyProductAdd_Click(object sender, EventArgs e)
        {
            Part addedPart = (Part)gridModifyProductAllCandidateParts.CurrentRow.DataBoundItem;
            addedParts.Add(addedPart);
            gridModifyProductAssociatedParts.Update();
            gridModifyProductAssociatedParts.ClearSelection();
        }

        //Checks search box input and finds part either by name, or by id.
        private void btnModifyProductSearch_Click(object sender, EventArgs e)
        {
            gridModifyProductAllCandidateParts.ClearSelection();
            if (txtModifyProductSearch.Text.Length > 0)
            {
                if (!Int32.TryParse(txtModifyProductSearch.Text, out number))//search by name
                {
                    //search for first instance of text 
                    foreach (Part part in Inventory.AllParts)
                    {
                        if (part.Name.ToLower().Contains(txtModifyProductSearch.Text.ToLower()))
                        {
                            gridModifyProductAllCandidateParts.Rows[part.PartID - 1].Selected = true;
                            break;
                        }
                    }

                }
                else //search by ID
                {
                    Part found = Inventory.lookupPart(int.Parse(txtModifyProductSearch.Text));
                    foreach (DataGridViewRow row in gridModifyProductAllCandidateParts.Rows)
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
                gridModifyProductAllCandidateParts.ClearSelection();
                return;
            }
        }

        //Clears grid selections.
        private void ModifyProductScreen_Load(object sender, EventArgs e)
        {
            gridModifyProductAllCandidateParts.ClearSelection();
            gridModifyProductAssociatedParts.ClearSelection();
        }

        //Exits modify product screen.
        private void btnModifyProductCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
