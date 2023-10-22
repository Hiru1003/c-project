using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //creating sql connection
            int ID=int.Parse(txtID.Text);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Dropbox\PC (2)\Documents\lastDB.mdf"";Integrated Security=True;Connect Timeout=30");

            //creating sql query
            string qry = "insert into InFoTable values ('" + ID + "') ";

            //create the command 
            SqlCommand cmd = new SqlCommand(qry, con);

            //handling exceptions
            try
            {
                con.Open(); //opening conncetion
                cmd.ExecuteNonQuery(); //executing query
                MessageBox.Show("Data Inserted Successfully");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //creating sql connection
            int ID = int.Parse(txtID.Text);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Dropbox\PC (2)\Documents\lastDB.mdf"";Integrated Security=True;Connect Timeout=30");

            //creating sql query
            string qry = "delete from InFoTable where ID = '"+ID+"' ";

            //create the command 
            SqlCommand cmd = new SqlCommand(qry, con);

            //handling exceptions
            try
            {
                con.Open(); //opening conncetion
                cmd.ExecuteNonQuery(); //executing query
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //creating sql connection
            int ID = int.Parse(txtID.Text);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Dropbox\PC (2)\Documents\lastDB.mdf"";Integrated Security=True;Connect Timeout=30");

            //creating sql query
            string qry = "update SET  InFoTable where ID = '" + ID + "' ";

            //create the command 
            SqlCommand cmd = new SqlCommand(qry, con);

            //handling exceptions
            try
            {
                con.Open(); //opening conncetion
                cmd.ExecuteNonQuery(); //executing query
                MessageBox.Show("Data Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}