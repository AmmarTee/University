using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ammar", "Data Source=database-1.cmdikv4inm6j.ap-south-1.rds.amazonaws.com;Initial Catalog=personal;Persist Security Info=True;User ID=admin;Password=12345678");
            DataSet ds = new DataSet();
            da.Fill(ds, "users");
            dataGridView1.DataSource = ds.Tables["users"].DefaultView;
        }
    }
}
