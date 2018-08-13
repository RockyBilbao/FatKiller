using System;
using System.Windows.Forms;

namespace FatKillerSimpleAdministrator
{
    public partial class AdministratorMainPanel : Form
    {
        public AdministratorMainPanel()
        {
            InitializeComponent();
        }

        private void GoToProductManagerButton_Click(object sender, EventArgs e)
        {
            new ProductManagerPanel().Show();
        }
    }
}
