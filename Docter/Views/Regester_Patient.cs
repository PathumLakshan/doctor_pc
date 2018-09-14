using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Docter.DataAccess;
using Docter.DataOperations;
using Docter.VarStore;

namespace Docter.Views
{
    public partial class Regester_Patient : Form
    {
        string name, age, mobieNumber, gender, NIC, address;
        int count;
        dataCount_del d_count = new dataCount_del(new NewFuncs().dataCount);

        query_del q_del = new query_del(new Queries().queryWithPara);

        public Regester_Patient()
        {
            InitializeComponent();
        }

        private void Regester_Patient_Load_1(object sender, EventArgs e)
        {
            count = d_count(q_del("countPatients"));

            txtpid.Text = (count+1).ToString();

        }

        private void txtnumber_TextChanged_1(object sender, EventArgs e)
        {
            mobieNumber = txtnumber.Text;
        }

        private void txtgender_TextChanged_1(object sender, EventArgs e)
        {
            gender = txtgender.Text;
        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnic_TextChanged_1(object sender, EventArgs e)
        {
            NIC = txtnic.Text;
        }

        private void txtpaddress_TextChanged_1(object sender, EventArgs e)
        {
            address = txtpaddress.Text;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            age = txtAge.Text;
        }

        private void txtpname_TextChanged_1(object sender, EventArgs e)
        {
            name = txtpname.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = new dbOperations().InsertData("insert into Patient_Details(Patient_Name, Age, P_Number, Patient_Gender, Patient_NIC, P_Address) Values('" + name + "', '" + age + "', '" + mobieNumber + "', '" + gender + "', '" + NIC + "', '" + address + "')"); 
           
            
            if (i > 0)
            {
                MessageBox.Show("New Patient Added Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("New Patient Adding Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear();
            count = count + 1;
            txtpid.Text = count.ToString();
        }
        public void clear()
        {
            txtpname.Text="";
            txtAge.Text="";
            txtpaddress.Text="";
            txtnic.Text="";
            txtgender.Text="";
            txtnumber.Text="";
        }
    }
}
