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

namespace Docter.Views
{
    public partial class Treatments : Form
    {
        //private static string constr = "Data Source=.;Initial Catalog=DOCTER;Integrated Security=True";
        dbOperations db = new dbOperations();
        int count;
        string pid, name, disease, prescription, rs;
        string date;

        private void txtpid_TextChanged(object sender, EventArgs e)
        {
            pid = txtpid.Text;
        }

        private void comboxPname_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = comboxPname.Text;
            txtpid.Text = db.GetStringValue("Select Patient_ID from Patient_Details where Patient_Name='" + name + "';");
        }

        private void txtdisease_TextChanged(object sender, EventArgs e)
        {
            disease = txtdisease.Text;
        }

        private void txtprescription_TextChanged(object sender, EventArgs e)
        {
            prescription = txtprescription.Text;
        }

        private void dateTreatment_ValueChanged(object sender, EventArgs e)
        {
            date = dateTreatment.Value.Date.ToString("yyyy-MM-dd");
        }

        private void txtrs_TextChanged(object sender, EventArgs e)
        {
            rs = txtrs.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into Treatment(Patient_ID,Patient_Name,Disease,Prescription,Date,Rs) Values('" + pid + "','" + name + "','" + disease + "' ,'" + prescription + "' ,'" + date + "','" + rs + "');";

            if(db.InsertData(insertQuery) > 0){
                MessageBox.Show("Treatment Details Inserted Successful","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Treatment Details Inserting Failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            txtdisease.Clear();
            txtpid.Clear();
            txtprescription.Clear();
            txtrs.Clear();
            count = count + 1;
            txttid.Text = count.ToString();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdisease.Clear();
            txtpid.Clear();
            txtprescription.Clear();
            txtrs.Clear();

        }

        public Treatments()
        {
            InitializeComponent();
        }

        private void Treatments_Load(object sender, EventArgs e)
        {
            string sql = "select count(Treatment_ID)  from Treatment;";
            string sql1 = "select Patient_Name from Patient_Details";
            count = db.GetIntValue(sql);
            // set data from database to combo box
            comboxPname.DataSource = db.SelectOneColumn(sql1).Tables[0];
            comboxPname.DisplayMember = "Patient_Name";

            comboxPname.Text = "Select Patient";
            dateTreatment.Value = DateTime.Today;
            
            txttid.Text = (count+1).ToString();
            
           
        }

        
    }
}
