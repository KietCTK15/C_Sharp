using Repositories.Models;
using Services;

namespace BookManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAccountServices userAccountServices = new UserAccountServices();
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                UserAccount? loginUser = userAccountServices.LoginAccount(txtUserName.Text, txtPassword.Text);

                if (loginUser != null)
                {
                    if (loginUser.Role == 3)
                    {
                        this.Hide();
                        Form frmMember = new Form();
                        frmMember.ShowDialog();
                        this.Close();
                    }
                    else if (loginUser.Role == 2)
                    {
                        this.Hide();
                        Form frmStaff = new Form();
                        frmStaff.ShowDialog();
                        this.Close();
                    }
                    else if (loginUser.Role == 1)
                    {
                        this.Hide();
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.ShowDialog();
                        this.Close();
                    }
                }
                else MessageBox.Show("User Name or Password wrong!!!", "LOGIN FAIL");

            }
            else MessageBox.Show("User Name and Password cannot Empty!!!", "WARNING");


        }

        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            frmRegister frmregister = new frmRegister();
            frmregister.ShowDialog();
            this.Show();
        }
    }
}
