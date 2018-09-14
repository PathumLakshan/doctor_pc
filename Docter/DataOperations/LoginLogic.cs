using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Docter.Crypto;
using Docter.DataAccess;

namespace Docter.DataOperations
{
    public delegate void tryLogin(string name, string pswd);

    public class LoginLogic
    {
        dbOperations db = new dbOperations();

        public bool TryLogin(string username, string password)
        {
            string decryptedstring = StringCipher.Decrypt(db.GetStringValue("select password from login where UserName='" + username + "'"), username);

            if (decryptedstring == password)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void  testMeth()
        {
            
        }

       
    }
}
