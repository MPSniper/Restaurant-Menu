namespace UI
{
    public partial class MainResturanForm : Form
    {
        private Form activeForm;
        private Button currentButton;
        public int ResturantKey { get; set; }
        public int ID { get; set; }

        public MainResturanForm()
        {
            InitializeComponent();
        }

        private void BtnFoods_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FoodsForm()
            {
                ResturantKey = ID,
            }, sender);
        }

        #region Open Child Forms

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(childForm);
            PanelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Coral;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(252, 194, 252);
                }
            }
        }

        #endregion

        private void BtnFactors_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FactorsForm() { ID = ID }, sender);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SplashForm().Show();
        }
    }
}
