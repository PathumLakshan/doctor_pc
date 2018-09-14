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
    public partial class Patient_Treatment_Details : Form
    {
        string name, minDate,maxDate;

        data3_del d_del3 = new data3_del(new NewFuncs().data3);
        
        query_del q_del = new query_del(new Queries().queryWithPara);
        Queries q = new Queries();

        public Patient_Treatment_Details()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            minDate = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            maxDate = DateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                DataGridView1.DataSource = d_del3(q_del("PDandTr",name);

            }catch(Exception ex)
            {
                MessageBox.Show("Patient Not Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataGridView1.DataSource = d_del3(q_del("PDandTr2",minDate,maxDate));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Patient Details Not Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView1.DataSource = d_del3(q_del("PDandTr2", minDate, maxDate));
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Patient Details Not Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
          
            DataGridView1.Refresh();
        }

        private void txtpname_TextChanged(object sender, EventArgs e)
        {
            name = txtpname.Text;
        }

        private void Patient_Treatment_Details_Load(object sender, EventArgs e)
        {
        }
    }
}
