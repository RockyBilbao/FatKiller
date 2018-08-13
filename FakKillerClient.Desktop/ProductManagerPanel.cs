using FatKillerSimpleAdministrator.Service;
using System;
using System.Windows.Forms;

namespace FatKillerSimpleAdministrator
{
    public partial class ProductManagerPanel : Form
    {
        public ProductManagerPanel()
        {
            InitializeComponent();
            operationChoiceCombobox.Items.Add("Dodaj produkt");     //TODO string do resources
            operationChoiceCombobox.Items.Add("Edytuj produkt");    //TODO string do resources
            operationChoiceCombobox.Items.Add("Usuń produkt");      //TODO string do resources
        }

        private void ProductManagerPanel_Load(object sender, EventArgs e)
        {
            //HttpClientHelper.GetData()
        }

        private void OperationChoiceCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductManagerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ConfirmOperationButton_Click(object sender, EventArgs e)
        {
            //TODO ProductService
            var productToAdd = new Product();


            //TODO OPEN CLOSED PRINCIPLE

            switch (operationChoiceCombobox.SelectedText)
            {
                case "Dodaj produkt":
                    HttpClientHelper.AddData()
                    break;
            }
        }
    }
}
