using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool isOK = false;
            isOK = Account.Login(textBox1.Text, textBox2.Text);
            if (isOK)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }
    }

    class Account
    {
        public static bool Login(string usercode, string password)
        {
            string connstr = Properties.Settings.Default.cjglxtConnectionString;
            try
            {
                using (var conn = new OleDbConnection(connstr))
                {
                    conn.Open();
                    string sql = string.Format("select password from admin where usercode=\"{0}\"", usercode);
                    var comm = new OleDbCommand(sql, conn);
                    object obj = comm.ExecuteScalar();
                    if (obj == null)
                    {
                        MessageBox.Show("用户名错误");
                        return false;
                    }
                    if (obj.ToString() != password)
                    {
                        MessageBox.Show("用户名错误");
                        return false;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message); 
            }
            return true;
        }
    }
}
