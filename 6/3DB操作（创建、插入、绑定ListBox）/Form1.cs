using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            for (int i = 0; i <= 10; i++)
            {
                DataRow dr = dataTable.NewRow();
                dr["name"] = "X" + i.ToString();
                dr["age"] = 60 + i;
                dataTable.Rows.Add(dr);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("age", typeof(int));

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "age";
            listBox1.DataSource = bindingSource;

            dataGridView1.DataSource = bindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Remove(dataTable.Rows[0]);
        }
    }
}
