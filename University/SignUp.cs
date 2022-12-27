using System.Data;
using System.Data.SqlClient;

namespace University
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }

      

        private void initAdapter()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length==0)
            {
                MessageBox.Show("Please enter your username");
                return;
            }

            else if (textBox3.Text!=textBox1.Text)
            { 
                MessageBox.Show("Password Does not Match");
                return;

            }

            else if(textBox3.Text.Length < 8)
            {
                MessageBox.Show("Password Can't be lower than 8 characters");

            }
            else
            {

                SqlConnection con = new SqlConnection("Data Source=database-1.cmdikv4inm6j.ap-south-1.rds.amazonaws.com;Initial Catalog=ammar;Persist Security Info=True;User ID=admin;Password=12345678");
                con.Open();
                string qur = "INSERT INTO users VALUES ('" + textBox2.Text + "','" + textBox3.Text + "')";
                SqlCommand cmd = new SqlCommand(qur, con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                new Login().Show();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.Text = "";


            }

        }

    }
}