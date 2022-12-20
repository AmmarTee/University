using System.Data;
using System.Data.SqlClient;

namespace University
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", "Data Source=database-1.cmdikv4inm6j.ap-south-1.rds.amazonaws.com;Initial Catalog=personal;Persist Security Info=True;User ID=admin;Password=12345678");
            DataSet ds = new DataSet();
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"].DefaultView;
        }

        private void initAdapter()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=database-1.cmdikv4inm6j.ap-south-1.rds.amazonaws.com;Initial Catalog=personal;Persist Security Info=True;User ID=admin;Password=12345678");
            con.Open();
            string qur = "INSERT INTO Student VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted sucessfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }


    }
}