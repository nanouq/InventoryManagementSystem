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
    public partial class ModifyPartScreen : Form
    {
        bool isInhouse;
        ErrorProvider nameErr = new ErrorProvider();
        ErrorProvider invErr = new ErrorProvider();
        ErrorProvider priceErr = new ErrorProvider();
        ErrorProvider minErr = new ErrorProvider();
        ErrorProvider maxErr = new ErrorProvider();
        ErrorProvider inHouseOutsourcedErr = new ErrorProvider();
        MainScreen main = (MainScreen)Application.OpenForms["MainScreen"];
        public ModifyPartScreen(InHouse inhouse)
        {
            InitializeComponent();

            txtModifyPartID.Text = inhouse.PartID.ToString();
            txtModifyPartName.Text = inhouse.Name.ToString();
            txtModifyPartInventory.Text = inhouse.InStock.ToString();
            txtModifyPartPrice.Text = inhouse.Price.Substring(1);
            txtModifyPartMin.Text = inhouse.Min.ToString();
            txtModifyPartMax.Text = inhouse.Max.ToString();
            txtModifyPartMachineIDCompanyName.Text = Convert.ToString(inhouse.MachineID);
            isInhouse= true;
        }
        public ModifyPartScreen(Outsourced outsourced)
        {
            InitializeComponent();
            txtModifyPartID.Text = outsourced.PartID.ToString();
            txtModifyPartName.Text = outsourced.Name;
            txtModifyPartInventory.Text = outsourced.InStock.ToString();
            txtModifyPartPrice.Text = outsourced.Price.Substring(1);
            txtModifyPartMin.Text = outsourced.Min.ToString();
            txtModifyPartMax.Text = outsourced.Max.ToString();
            txtModifyPartMachineIDCompanyName.Text = outsourced.CompanyName;

            rdBtnModifyPartOutsourced.Checked = true;
            lblModifyPartMachineIDCompanyName.Text = "Company Name";
            isInhouse= false;
        }

        //Checks if all fields are filled out. If so, enables the use of the save button.
        private void checkIfComplete()
        {
            if (txtModifyPartName.BackColor != Color.Salmon && txtModifyPartInventory.BackColor != Color.Salmon && txtModifyPartPrice.BackColor != Color.Salmon && txtModifyPartMin.BackColor != Color.Salmon && txtModifyPartMax.BackColor != Color.Salmon && txtModifyPartMachineIDCompanyName.BackColor != Color.Salmon)
            {
                btnModifyPartSave.Enabled = true;
            }
            else
            {
                btnModifyPartSave.Enabled = false;
            }
        }

        //Determine which radio button is currently selected and verifies input.
        private void checkOnRBSwitch()
        {
            int number;
            if (isInhouse) //if radio button is checked to inhouse
            {
                if (string.IsNullOrEmpty(txtModifyPartMachineIDCompanyName.Text)) //if machine id is empty
                {
                    txtModifyPartMachineIDCompanyName.BackColor = Color.Salmon;

                    inHouseOutsourcedErr.SetError(txtModifyPartMachineIDCompanyName, "Machine ID required");
                }
                else if (!Int32.TryParse(txtModifyPartMachineIDCompanyName.Text, out number)) //if machine id is not a number, flag an error
                {
                    txtModifyPartMachineIDCompanyName.BackColor = Color.Salmon;

                    inHouseOutsourcedErr.SetError(txtModifyPartMachineIDCompanyName, "Machine ID must be numberic");
                }
                else
                {
                    txtModifyPartMachineIDCompanyName.BackColor = Color.White;
                    inHouseOutsourcedErr.Clear();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtModifyPartMachineIDCompanyName.Text)) //if company name is empty, flag an error
                {
                    txtModifyPartMachineIDCompanyName.BackColor = Color.Salmon;

                    inHouseOutsourcedErr.SetError(txtModifyPartMachineIDCompanyName, "Company name required");
                }
                else
                {
                    txtModifyPartMachineIDCompanyName.BackColor = Color.White;
                    inHouseOutsourcedErr.Clear();
                }
            }
        }

        //Changes part type to outsourced and makes necessary changes.
        private void rdBtnModifyPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblModifyPartMachineIDCompanyName.Text = "Company Name";
            isInhouse= false;
            checkOnRBSwitch();
        }

        //Closes modify parts screen.
        private void btnModifyPartCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Changes part type to inhouse and makes necessary changes.
        private void rdBtnModifyPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblModifyPartMachineIDCompanyName.Text = "Machine ID";
            isInhouse = true;
            checkOnRBSwitch();
        }

        //Validates part name input.
        private void txtModifyPartName_TextChanged(object sender, EventArgs e)
        {
            //if part name is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyPartName.Text))
            {
                txtModifyPartName.BackColor = Color.Salmon;
                nameErr.SetError(txtModifyPartName, "Part name required");
            }
            else
            {
                txtModifyPartName.BackColor = Color.White;
                nameErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part inventory input.
        private void txtModifyPartInventory_TextChanged(object sender, EventArgs e)
        {
            int number;
            //if inventory is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyPartInventory.Text))
            {
                txtModifyPartInventory.BackColor = Color.Salmon;

                invErr.SetError(txtModifyPartInventory, "Inventory required");
            }
            else if (!Int32.TryParse(txtModifyPartInventory.Text, out number)) //if inventory is not a number, flag an error
            {
                txtModifyPartInventory.BackColor = Color.Salmon;

                invErr.SetError(txtModifyPartInventory, "Inventory must be numeric");
            }
            else
            {
                txtModifyPartInventory.BackColor = Color.White;
                invErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part price input.
        private void txtModifyPartPrice_TextChanged(object sender, EventArgs e)
        {
            decimal number2;
            //if price is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyPartPrice.Text))
            {
                txtModifyPartPrice.BackColor = Color.Salmon;

                priceErr.SetError(txtModifyPartPrice, "Price required");
            }
            else if (!Decimal.TryParse(txtModifyPartPrice.Text, out number2)) //if price is not a number, flag an error
            {
                txtModifyPartPrice.BackColor = Color.Salmon;

                priceErr.SetError(txtModifyPartPrice, "Price must be numeric");
            }
            else
            {
                txtModifyPartPrice.BackColor = Color.White;
                priceErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part max input.
        private void txtModifyPartMax_TextChanged(object sender, EventArgs e)
        {
            int number;
            //if max is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyPartMax.Text))
            {
                txtModifyPartMax.BackColor = Color.Salmon;
                maxErr.SetError(txtModifyPartMax, "Max required");
            }
            else if (!Int32.TryParse(txtModifyPartMax.Text, out number)) //if max is not a number, flag an error
            {
                txtModifyPartMax.BackColor = Color.Salmon;

                maxErr.SetError(txtModifyPartMax, "Max must be numeric");
            }
            else
            {
                txtModifyPartMax.BackColor = Color.White;
                maxErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part min input.
        private void txtModifyPartMin_TextChanged(object sender, EventArgs e)
        {
            int number;
            //if min is empty, flag an error
            if (string.IsNullOrEmpty(txtModifyPartMin.Text))
            {
                txtModifyPartMin.BackColor = Color.Salmon;
                minErr.SetError(txtModifyPartMin, "Min required");
            }
            else if (!Int32.TryParse(txtModifyPartMin.Text, out number)) //if min is not a number, flag an error
            {
                txtModifyPartMin.BackColor = Color.Salmon;
                minErr.SetError(txtModifyPartMin, "Min must be numeric");
            }
            else
            {
                txtModifyPartMin.BackColor = Color.White;
                minErr.Clear();
            }
            checkIfComplete();
        }

        //Validates part machine id or company name input.
        private void txtModifyPartMachineIDCompanyName_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
            checkIfComplete();
        }

        //Validates all values and updates part in inventory.
        private void btnModifyPartSave_Click(object sender, EventArgs e)
        {
            string name = txtModifyPartName.Text;
            decimal price = decimal.Parse(txtModifyPartPrice.Text);
            int instock = int.Parse(txtModifyPartInventory.Text);
            int min = int.Parse(txtModifyPartMin.Text);
            int max = int.Parse(txtModifyPartMax.Text);

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
                int machineID = int.Parse(txtModifyPartMachineIDCompanyName.Text);
                InHouse inhouse = new InHouse(int.Parse(txtModifyPartID.Text), name, price, instock, min, max, machineID);
                Inventory.updatePart(inhouse.PartID, inhouse);
            }
            else if (!isInhouse)
            {
                string companyName = txtModifyPartMachineIDCompanyName.Text;
                Outsourced outsourced = new Outsourced(int.Parse(txtModifyPartID.Text), name, price, instock, min, max, companyName);
                Inventory.updatePart(outsourced.PartID, outsourced);
            }

            this.Close();
            main.Refresh();
        }

        private void ModifyPartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
