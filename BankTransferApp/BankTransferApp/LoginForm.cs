using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankTransferApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9UK4PN;Initial Catalog=BankDb; Integrated Security=True");

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From PersonInformation where AccountNo=@p1 and Password=@p2 ", connection);
            command.Parameters.AddWithValue("@p1", MskAccountNo.Text);
            command.Parameters.AddWithValue("@p2", PasswordTextBox.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                DetailForm detailForm = new DetailForm();
                detailForm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            connection.Close();
        }
    }
}
