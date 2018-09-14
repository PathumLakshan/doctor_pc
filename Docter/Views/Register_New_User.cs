using System;
using System.Windows.Forms;
using Docter.DataAccess;
using Docter.Crypto;

namespace Docter.Views
{
    public partial class Register_New_User : Form
    {
        private string name, pass;
        //private static string constring = "Data Source=.;Initial Catalog=DOCTER;Integrated Security=True";
        dbOperations db = new dbOperations();

        

        public Register_New_User()
        {
            InitializeComponent();
        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {
            name = txtlname.Text;
        }

        private void txtpword_TextChanged(object sender, EventArgs e)
        {
            
            pass = txtpword.Text;
        }

        private void Register_New_User_Load(object sender, EventArgs e)
        {
            string sql = "select count(UserName) from Login";
            int count = db.GetIntValue(sql);
            if (count>0)
            {
                txtuid.Text = count.ToString();
            }
            else
            {
                txtuid.Text = txtuid.Text;
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtlname.Clear();
            txtpword.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string password = StringCipher.Encrypt(name, pass);
            string insertQuery = "insert into Login(UserName,Password) Values('" + name + "','" + password + "');";
            if (db.InsertData(insertQuery)>0)
            {
                MessageBox.Show("New User Added Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Login().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("New User Adding FAiled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
