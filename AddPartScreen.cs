using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddPartScreen : Form
    {
        ErrorProvider nameErr = new ErrorProvider();
        ErrorProvider invErr = new ErrorProvider();
        ErrorProvider priceErr = new ErrorProvider();
        ErrorProvider minErr = new ErrorProvider();
        ErrorProvider maxErr = new ErrorProvider();
        ErrorProvider inHouseOutsourcedErr = new ErrorProvider();
        bool isInhouse = true;
        public AddPartScreen()
        {
            InitializeComponent();
            txtAddPartID.Text = (Inventory.AllParts.Last().PartID + 1).ToString();
        }

        //Determines which radio button is currently selected and verifies input.
        private void checkOnRBSwitch()
        {
            int number;
            if (isInhouse)
            {
                if (string.IsNullOrEmpty(txtAddPartMachineIDCompanyName.Text))
                {
                    txtAddPartMachineIDCompanyName.BackColor = Color.Salmon;

                    inHouseOutsourcedErr.SetError(txtAddPartMachineIDCompanyName, "Machine ID required");
                }
                else if (!Int32.TryParse(txtAddPartMachineIDCompanyName.Text, out number))
                {
                    txtAddPartMachineIDCompanyName.BackColor = Color.Salmon;

                    inHouseOutsourcedErr.SetError(txtAddPartMachineIDCompanyName, "Machine ID must be numberic");
                }
                else
                {
                    txtAddPartMachineIDCompanyName.BackColor = Color.White;
                    inHouseOutsourcedErr.Clear();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtAddPartMachineIDCompanyName.Text))
                {
                    txtAddPartMachineIDCompanyName.BackColor = Color.Salmon;

                    inHouseOutsourcedErr.SetError(txtAddPartMachineIDCompanyName, "Company name required");
                }
                else
                {
                    txtAddPartMachineIDCompanyName.BackColor = Color.White;
                    inHouseOutsourcedErr.Clear();
                }
            }
        }

        //Enables the use of the save button if all fields are filled out accurately.
        private void checkIfComplete()
        {
            if(txtAddPartName.BackColor != Color.Salmon && txtAddPartInventory.BackColor != Color.Salmon && txtAddPartPrice.BackColor != Color.Salmon && txtAddPartMin.BackColor != Color.Salmon && txtAddPartMax.BackColor != Color.Salmon && txtAddPartMachineIDCompanyName.BackColor != Color.Salmon)
            {
                btnAddPartSave.Enabled = true;
            }
            else
            {
                btnAddPartSave.Enabled= false;
            }
        }

        //Validates all values and adds part to inventory.
        private void btnAddPartSave_Click(object sender, EventArgs e)
        {
            string name = txtAddPartName.Text;
            decimal price = decimal.Parse(txtAddPartPrice.Text);
            int instock = int.Parse(txtAddPartInventory.Text);
            int min = int.Parse(txtAddPartMin.Text);
            int max = int.Parse(txtAddPartMax.Text);
                     
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
            else if (isInhouse)
            {
                int machineID = int.Parse(txtAddPartMachineIDCompanyName.Text);
                InHouse inhouse = new InHouse((Inventory.AllParts.Last().PartID + 1), name, price, instock, min, max, machineID);
                Inventory.addPart(inhouse);
            }
            else if (!isInhouse)
            {
                string companyName = txtAddPartMachineIDCompanyName.Text;
                Outsourced outsourced = new Outsourced((Inventory.AllParts.Last().PartID + 1), name, price, instock, min, max, companyName);
                Inventory.addPart(outsourced);
            }

                Close();
        }

        //Closes add part screen and returns to the main screen.
        private void btnAddPartCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Changes part type to inhouse and makes necessary changes.
        private void rdBtnAddPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblAddPartMachineIDCompanyName.Text = "Machine ID";
            isInhouse = true;
            checkOnRBSwitch();
        }

        //Changes part type to outsourced and makes necessary changes.
        private void rdBtnAddPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblAddPartMachineIDCompanyName.Text = "Company Name";
            isInhouse = false;
            checkOnRBSwitch();

        }

        //Validates part name input.
        private void txtAddPartName_TextChanged(object sender, EventArgs e)
        {
            //if part name is empty, flag an error
            if (string.IsNullOrEmpty(txtAddPartName.Text))
            {
                txtAddPartName.BackColor = Color.Salmon;          
                nameErr.SetError(txtAddPartName, "Part name required");
            }
            else 
            {
                txtAddPartName.BackColor = Color.White;
                nameErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part inventory input.
        private void txtAddPartInventory_TextChanged(object sender, EventArgs e)
        {
            int number;
            //if inventory is empty, flag an error
            if (string.IsNullOrEmpty(txtAddPartInventory.Text))
            {
                txtAddPartInventory.BackColor = Color.Salmon;

                invErr.SetError(txtAddPartInventory, "Inventory required");
            }
            else if (!Int32.TryParse(txtAddPartInventory.Text, out number)) //if inventory is not a number, flag an error
            {
                txtAddPartInventory.BackColor = Color.Salmon;

                invErr.SetError(txtAddPartInventory, "Inventory must be numeric");
            }
            else
            {
                txtAddPartInventory.BackColor = Color.White;
                invErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part price input.
        private void txtAddPartPrice_TextChanged(object sender, EventArgs e)
        {
            decimal number2;
            //if price is empty, flag an error
            if (string.IsNullOrEmpty(txtAddPartPrice.Text))
            {
                txtAddPartPrice.BackColor = Color.Salmon;

                priceErr.SetError(txtAddPartPrice, "Price required");
            }
            else if (!Decimal.TryParse(txtAddPartPrice.Text, out number2)) //if price is not a number, flag an error
            {
                txtAddPartPrice.BackColor = Color.Salmon;

                priceErr.SetError(txtAddPartPrice, "Price must be numeric");
            }
            else
            {
                txtAddPartPrice.BackColor = Color.White;
                priceErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part max input.
        private void txtAddPartMax_TextChanged(object sender, EventArgs e)
        {
            int number;
            //if max is empty, flag an error
            if (string.IsNullOrEmpty(txtAddPartMax.Text))
            {
                txtAddPartMax.BackColor = Color.Salmon;
                maxErr.SetError(txtAddPartMax, "Max required");
            }
            else if (!Int32.TryParse(txtAddPartMax.Text, out number)) //if max is not a number, flag an error
            {
                txtAddPartMax.BackColor = Color.Salmon;

                maxErr.SetError(txtAddPartMax, "Max must be numeric");
            }
            else
            {
                txtAddPartMax.BackColor = Color.White;
                maxErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part min input.
        private void txtAddPartMin_TextChanged(object sender, EventArgs e)
        {
            int number;
            //if min is empty, flag an error
            if (string.IsNullOrEmpty(txtAddPartMin.Text))
            {
                txtAddPartMin.BackColor = Color.Salmon;
                minErr.SetError(txtAddPartMin, "Min required");
            }
            else if (!Int32.TryParse(txtAddPartMin.Text, out number)) //if min is not a number, flag an error
            {
                txtAddPartMin.BackColor = Color.Salmon;
                minErr.SetError(txtAddPartMin, "Min must be numeric");
            }
            else
            {
                txtAddPartMin.BackColor = Color.White;
                minErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part machine id or company name input.
        private void txtAddPartMachineIDCompanyName_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
            checkIfComplete();
        }

        private void AddPartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
