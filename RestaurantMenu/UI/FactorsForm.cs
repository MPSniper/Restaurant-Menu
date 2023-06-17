
using Repository.DataModel;

namespace UI
{

    public partial class FactorsForm : Form
    {
        public int ID { get; set; }

        public FactorsForm()
        {
            InitializeComponent();
        }

        private void LoadFactors(object sender, EventArgs e)
        {
            Factors factors = new Factors();
            (DataFactors.DataSource, label12.Text) = factors.ShowFactors(ID);
        }
    }
}