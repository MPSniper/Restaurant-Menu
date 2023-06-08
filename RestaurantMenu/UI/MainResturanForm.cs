using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainResturanForm : Form
    {
        public int ResturanKey { get; set; }

        public MainResturanForm()
        {
            InitializeComponent();
        }

        private void BtnFoods_Click(object sender, EventArgs e)
        {
            new FoodsForm()
            {
                ResturanKey = ResturanKey,
            }.ShowDialog();
        }

        private void BtnFactors_Click(object sender, EventArgs e)
        {
            new FactorsForm().ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
