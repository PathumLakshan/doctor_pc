using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docter.Views
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
            
        }
        public Main_Window(string LogName)
        {
            InitializeComponent();
            this.LogName = LogName;
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            lblUser.Text = this.LogName;
        }

        private void addNewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public string LogName { get; set; }

        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regester_Patient fm = new Regester_Patient();
            fm.Show();
        }

        private void newTreatmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treatments fm = new Treatments();
            fm.Show();
        }

        private void advancedTreatmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Advance_Treatments fm = new Advance_Treatments();
            fm.Show();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient_Details fm = new Patient_Details();
            fm.Show();
        }

        private void patientTreatmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient_Treatment_Details fm = new Patient_Treatment_Details();
            fm.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_New_User fm = new Register_New_User();
            fm.Show();
        }

        private void updatePatientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Patient fm = new Update_Patient();
            fm.Show();
        }

        private void patientReportsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Available here !");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abou_Us fm = new Abou_Us();
            fm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
