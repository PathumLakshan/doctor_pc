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
using Docter.VarStore;
using Docter.DataOperations;

namespace Docter.Views
{
    
    public partial class Update_Patient : Form
    {
        #region object_instance_area

        string pid,name,newName, age, mobieNumber, gender, NIC, address;
        data_del d_del = new data_del(new NewFuncs().data);
        data2_del d_del2 = new data2_del(new NewFuncs().data2);
        query_del q_del = new query_del(new Queries().queryWithPara);
        Queries q = new Queries();
        DataRow dr;
        #endregion

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            age = txtAge.Text;
        }

        private void txtnic_TextChanged(object sender, EventArgs e)
        {
            NIC = txtnic.Text;
        }

        private void txtpaddress_TextChanged(object sender, EventArgs e)
        {
            address = txtpaddress.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newName = comboBox1.Text;
            string updateQuery = "update Patient_Details set Patient_Name = '" + newName + "', Age = '" + age + "', P_Number = '" +
                mobieNumber + "', Patient_Gender = '" + gender
                + "', Patient_NIC = '" + NIC + "',P_Address='" + address + "' where Patient_ID ='" + pid + "'";

            
            if (new dbOperations().UpdateData(updateQuery) > 0)
            {
                MessageBox.Show("Patient Details Updated Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Patient Details Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {
            pid = txtpid.Text;
        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {
            mobieNumber = txtnumber.Text;
        }

        private void txtgender_TextChanged(object sender, EventArgs e)
        {
            gender = txtgender.Text;
        }

        public Update_Patient()
        {
            InitializeComponent();
        }

        private void Update_Patient_Load(object sender, EventArgs e)
        {
            d_del(comboBox1, q_del("patientname"), "Patient_Name", "Select Patient");
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = comboBox1.Text;
            dr= d_del2(q_del("allpatientdet", name));

            txtpid.Text = dr["Patient_ID"].ToString();
            txtAge.Text = dr["Age"].ToString();
            txtgender.Text = dr["Patient_Gender"].ToString();
            txtnic.Text = dr["Patient_NIC"].ToString();
            txtnumber.Text = dr["P_Number"].ToString();
            txtpaddress.Text = dr["P_Address"].ToString();
        }
        public void clear()
        {
            txtnumber.Text="";
            txtpid.Text="";
            txtgender.Text="";
            txtpaddress.Text="";
            txtAge.Text="";
            txtnic.Text="";
        }
    }
}

