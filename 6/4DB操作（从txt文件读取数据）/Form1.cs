using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("x", typeof(double));
            dataTable.Columns.Add("y", typeof(double));
            dataTable.Columns.Add("deep", typeof(double));

            StreamReader sr = new StreamReader(@"F:\Downloads\waterdeep.txt");
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] words = line.Split('\t');
                double x = double.Parse(words[0]);
                double y = double.Parse(words[1]);
                double deep = double.Parse(words[2]);

                DataRow dr = dataTable.NewRow();
                dr["x"] = x;
                dr["y"] = y;
                dr["deep"] = deep;
                dataTable.Rows.Add(dr);
            }

            return dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = GetData();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }
    }
}
