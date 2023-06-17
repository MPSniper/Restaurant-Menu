using Repository.DataModel;

namespace UI
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtNationalCode.Text.Trim().Length != 10)
            {
                TxtNationalCode.Focus();
                MessageBox.Show("کد ملی وارد شده نامعتبر است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                TxtPassword.Focus();
                MessageBox.Show("رمز ورود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Users user = new Users();
                int id = user.Login(TxtNationalCode.Text.Trim(), TxtPassword.Text);
                if (id == 0)
                {
                    TxtNationalCode.Focus();
                    MessageBox.Show("اطلاعات وارد شده نادرست است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (id != -1)
                {
                    this.Hide();
                    MainUserForm userForm = new MainUserForm();
                    userForm.Id = id;
                    userForm.ShowDialog();
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SplashForm().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
