
using Repository.DataModel;

namespace UI
{
    public partial class FactorsForm : Form
    {
        public FactorsForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadFactors(object sender, EventArgs e)
        {
            Factors factors = new Factors();
          (DataFactors.DataSource, label12.Text) = factors.ShowFactors();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            
        }
    }
}