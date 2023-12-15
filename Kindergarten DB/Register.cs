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

namespace WindowsFormsApplication1
{
    public partial class Register : Form
    {
        SqlConnection cnn;
        public Register()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=.;Initial Catalog=kindergarten;Integrated Security=true;
                        User ID=; Password=;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");
            cnn.Close();
        }
        public void openDb()
        {
            string connectionString;
            //SqlConnection cnn;
            connectionString = @"Data Source=.; Initial Catalog=kindergarten; Integrated Security=true;
                        User ID=; Password=;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }
        public void closeDb()
        {
            cnn.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Your password does not matched");
            }
            else
            {
                Users user = new Users(txtName.Text, txtFamily.Text, txtAct.Text, txtUser.Text, txtPass.Text, txtCode.Text);
                openDb();
                MessageBox.Show("connection open");
                SqlCommand command;
                String Name = txtName.Text;
                String Family = txtFamily.Text;
                String Act = txtAct.Text;
                String User = txtUser.Text;
                String Pass = txtPass.Text;
                String Code = txtCode.Text;
                String connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=.; Initial Catalog=kindergarten; Integrated Security=true;
                        User ID=; Password=;";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(); //for insertion , Deletion , Update
                string sql, Output = "Insert Successfully added";


                sql = "INSERT INTO [kindergarten].[dbo].[Personal] (Pname, Pfamily, Pact, username, password, Code) VALUES('" + Name +
                    "','" + Family + "','" + Act +"','" + User + "','" + Pass + "','" + Code + "')";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();



                MessageBox.Show(Output);
                command.Dispose();
                closeDb();

                Main main = new Main(txtName.Text);
                this.Hide();
                main.ShowDialog();
                this.Close();
                 }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
