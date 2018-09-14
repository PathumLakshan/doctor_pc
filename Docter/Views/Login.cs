using System;
using System.Threading;
using System.Windows.Forms;
using Docter.DataOperations;

namespace Docter.Views
{
    delegate void delloading();

    public partial class Login : Form
    {
        LoginLogic newlogin = new LoginLogic();
        
        delloading del = new delloading(loading);
        public String UserName;

        public Login()
        {
            Thread t = new Thread(new ThreadStart(del));
            t.Start();
            InitializeComponent();
            for(int i = 0; i <= 500; i++)
            {
                Thread.Sleep(10);
            }
            t.Abort();
            this.Focus();
        }

         static void loading()
        {
           Splash frmsplash = new Splash();
           Application.Run(frmsplash);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool loginlogic = newlogin.TryLogin(txtuser_name.Text, txtPassword.Text);

            if (loginlogic)
            {
                this.UserName = txtuser_name.Text;
                MessageBox.Show("Login " + txtuser_name.Text + " Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_Window mw = new Main_Window(UserName);
                mw.LogName = UserName;
                mw.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        public String UserNames()
        {
            return UserName;
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
