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
using Repository.DataModel;

namespace UI
{
    public partial class UserRegisterForm : Form
    {
        ConnectToDB connect = new ConnectToDB();

        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            SplashForm splashForm = new SplashForm();
            splashForm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var userName = NameTextBox.Text;
            var userFamily = FamilyTextBox.Text;
            var userNation = NationalityTextBox.Text;
            var userAddress = AddressTextBox.Text;


            if (userName.Equals("") || userFamily.Equals("") || userNation.Equals("") || userAddress.Equals(""))
                MessageBox.Show("Please write name");
            //else if (userPassword.Equals(""))
            //    MessageBox.Show("Please write number");
            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into User_Table(FirstName,LastName,NationalCode,Address) values(@userName,@userFamily,@userNation,@userAddress)");
                insertcommand.Parameters.AddWithValue("@username", userName);
                insertcommand.Parameters.AddWithValue("@userFamily", userFamily);
                insertcommand.Parameters.AddWithValue("@userNation", userNation);
                insertcommand.Parameters.AddWithValue("@userAddress", userAddress);
                var row = connect.ExecuteQuery(insertcommand);
                if (row == 1)
                {
                    MessageBox.Show("SUCCESSFULL");
                    this.Hide();
                    MainUserForm mainUserForm = new MainUserForm();
                    mainUserForm.Show();
                }
                else
                {
                    MessageBox.Show("Error");

                }


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
