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
    public partial class Advance_Treatments : Form
    {
        string pid, name,disease, prescription, rs,date;
        int count;

        //delegates instatiation 
        data_del d_del = new data_del(new NewFuncs().data);
        data2_del d_del2 = new data2_del(new NewFuncs().data2);
        data3_del d_del3 = new data3_del(new NewFuncs().data3);
        dataCount_del d_count = new dataCount_del(new NewFuncs().dataCount);

        query_del q_del = new query_del(new Queries().queryWithPara);
        

        private void Advance_Treatments_Load(object sender, EventArgs e)
        {
            //use of delegates
            count = d_count(q_del("treatmentId"));
            d_del(comboxPname, q_del("patientname"), "Patient_Name", "Select Patient");

            dateTreatment.Value = DateTime.Today;
            txttid.Text = (count+1).ToString();
            
        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {
            pid = txtpid.Text;
        }

        private void comboxPname_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = comboxPname.Text;
            txtpid.Text = d_count(q_del("allpatientdet", comboxPname.Text)).ToString();
        }

        private void txtdisease_TextChanged(object sender, EventArgs e)
        {
            disease = txtdisease.Text;
        }

        private void txtprescription_TextChanged(object sender, EventArgs e)
        {
            prescription = txtprescription.Text;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTreatment.Value.Date.ToString("yyyy-MM-dd");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearField();
           
        }

        private void txtrs_TextChanged(object sender, EventArgs e)
        {
            rs = txtrs.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = d_del3(q_del("PDforId", pid));
            MessageBox.Show("Yeah");     
        }

        public void clearField()
        {
            comboxPname.Text = "";
            txtdisease.Text = "";
            txtprescription.Text = "";
            txtrs.Text = "";
            txtpid.Text = "";
            
        }
        

        public Advance_Treatments()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into Treatment(Patient_ID,Patient_Name,Disease,Prescription,Date,Rs) Values('" + pid + "','" + name + "','" + disease + "' ,'" + prescription + "' ,'" + date + "','" + rs + "');";
            
           
            if (new dbOperations().InsertData(insertQuery) > 0)
            {
                MessageBox.Show("Treatement Details Inserted Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Treatement Details Insert Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearField();
            count = count + 1;
            txttid.Text = count.ToString();
        }
    }
}
