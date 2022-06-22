using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection sql = null;
        private SqlDataAdapter data = null;
        private DataTable table = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            sql = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=PM2;Integrated Security=True");
            sql.Open();
            data = new SqlDataAdapter(@"SELECT * FROM Sale",sql);
            table = new DataTable();
            data.Fill(table);
            dgv1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Clear();
            data.Fill(table);
            dgv1.DataSource = table;
        }
    }
}
