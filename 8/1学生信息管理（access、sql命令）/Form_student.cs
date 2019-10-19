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
    public partial class Form_student : Form
    {
        public Form_student()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetList();
        }

        public static string GetList()
        {
            string ret = "";
            string connstr = Properties.Settings.Default.cjglxtConnectionString;
            try
            {
                using (var conn = new OleDbConnection(connstr))
                {
                    conn.Open();
                    string sql = "select * from student";
                    var comm = new OleDbCommand(sql, conn);
                    OleDbDataReader dr = comm.ExecuteReader();
                    while(dr.Read())
                    {
                        string name = dr[1].ToString();
                        string gender = dr[2].ToString();
                        ret += name + ":" + gender + "\r\n";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ret;
        }

        public static void Delete(string stuid)
        {
            string connstr = Properties.Settings.Default.cjglxtConnectionString;
            try
            {
                using (var conn = new OleDbConnection(connstr))
                {
                    conn.Open();
                    string sql = string.Format("delete from student where stuid = \"{0}\"",stuid);
                    var comm = new OleDbCommand(sql, conn);
                    int row = comm.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("删了");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Delete("1");
        }

        public static void Update()
        {
            string connstr = Properties.Settings.Default.cjglxtConnectionString;
            try
            {
                using (var conn = new OleDbConnection(connstr))
                {
                    conn.Open();
                    string sql = string.Format("update student set gender = '女'");
                    var comm = new OleDbCommand(sql, conn);
                    int row = comm.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("更新");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Update();
        }

        public static void Insert(string stuid, string name)
        {
            string connstr = Properties.Settings.Default.cjglxtConnectionString;
            try
            {
                using (var conn = new OleDbConnection(connstr))
                {
                    conn.Open();
                    string sql = string.Format("insert into student (stuid, name) values('{0}', '{1}')", stuid, name);
                    var comm = new OleDbCommand(sql, conn);
                    int row = comm.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("插入");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Insert(textBox2.Text,textBox3.Text);
        }
    }
}
