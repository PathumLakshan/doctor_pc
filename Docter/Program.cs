using Docter.Views;
using System;
using System.Windows.Forms;
using Docter.DataAccess;

namespace Docter
{
   
    static class Program
    {
        
        private static dbOperations db = new dbOperations();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!db.checkDatabaseExist())
            {
                db.GenerateDatabase();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int ck = db.GetIntValue("select count(UserName) from Login;");
            if (ck == 0)
            {
                MessageBox.Show("No User Account, Please Add User First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Run(new Register_New_User());

            }
            else
            {
                Application.Run(new Login());
            }
        }

    }
 }
