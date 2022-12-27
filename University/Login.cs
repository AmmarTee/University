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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=database-1.cmdikv4inm6j.ap-south-1.rds.amazonaws.com;Initial Catalog=ammar;Persist Security Info=True;User ID=admin;Password=12345678");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM users WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                new ShowData().Show();
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }
    }
}
