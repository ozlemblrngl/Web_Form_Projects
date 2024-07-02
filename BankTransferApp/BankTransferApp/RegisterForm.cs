using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankTransferApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9UK4PN;Initial Catalog=BankDb; Integrated Security=True");
        private void SaveButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into PersonInformation (FirstName, LastName, IdentityNo, Phone, AccountNo, Password) values (@p1, @p2, @p3, @p4, @p5, @p6)", connection); // buraya db'deki kolon adları yazılır
            command.Parameters.AddWithValue("@p1", FirstNameTextBox.Text);
            command.Parameters.AddWithValue("@p2", LastNameTextBox.Text);
            command.Parameters.AddWithValue("@p3", IdentityMaskedTextBox.Text);
            command.Parameters.AddWithValue("@p4", PhoneMaskedTextBox.Text);
            command.Parameters.AddWithValue("@p5", AccountNoMaskedTextBox.Text);
            command.Parameters.AddWithValue("@p6", PasswordTextBox.Text);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Client Information Saved");
            }
            else
            {
                MessageBox.Show("Client Information Not Saved");
            }
            connection.Close();

        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(100000, 10000000); // ilk değer dahil son değer dahil değil
            AccountNoMaskedTextBox.Text = number.ToString();
        }
    }
}
