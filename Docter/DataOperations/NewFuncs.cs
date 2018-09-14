using Docter.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Docter.VarStore;

namespace Docter.DataOperations
{

    public delegate void data_del(ComboBox cmb1, string s1, string s2, string s3);
    public delegate DataRow data2_del(string s4);
    public delegate DataTable data3_del(string s4);
    public delegate int dataCount_del(string sql);

    class NewFuncs
    {
        dbOperations db = new dbOperations();
        Queries q = new Queries();
              
        public void data(ComboBox cmb,string sql,string displayMem, string text)
        {
            cmb.DataSource = db.SelectOneColumn(sql).Tables[0];
            cmb.DisplayMember = displayMem;
            cmb.Text = text;
        }

        public DataRow data2(string sql)
        {
            DataRow dr = db.SelectMultipleDataSet(sql).Rows[0];
            return dr;
        }

        public DataTable data3(string sql)
        {
            DataTable dt = db.SelectMultipleDataSet(sql);
            return dt;
        }

        public int dataCount(string sql)
        {
            return db.GetIntValue(sql);
        }
    }
}
