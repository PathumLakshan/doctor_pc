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
    public partial class Patient_Details : Form
    {
        private static string name;
        data_del d_del = new data_del(new NewFuncs().data);
        data3_del d_del3 = new data3_del(new NewFuncs().data3);

        query_del q_del = new query_del(new Queries().queryWithPara);

        public Patient_Details()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = d_del3(q_del("PDetails", name));

            }
            catch(Exception ex)
            {
                MessageBox.Show("Patient Not Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.Write("This error"+ex);
            }
        }

        private void Patient_Details_Load(object sender, EventArgs e)
        {
            d_del(comboBox1, q_del("patientname"), "Patient_Name", "Select Patient");
            name = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = comboBox1.Text;
        }
    }
}
