using System;
using System.Windows.Forms;

namespace Cadogress
{
    public partial class InserterForm : Form
    {
        public InserterForm()
        {
            InitializeComponent();
        }


        private void AddInButton_Click(object sender, EventArgs e)
        {

            if (FieldValidations.checkEmptyFields(DescriptionBox.Text, QuantityBox.Text, ValueBox.Text))
            // Checks if all Textboxex were filled
            {
                if (FieldValidations.checkEnumFields(QuantityBox.Text) && FieldValidations.checkEnumFields(ValueBox.Text))
                // If all Textboxes were filled, it checks if Quantity and Value's Textboxes were filled with numeric values
                {
                    // Gets the result of formula Quantity x Value
                    double TotalValue = UpdateFields.getTotalValue(QuantityBox.Text, ValueBox.Text);
                    // Creates a string array for fill the ListView
                    string[] row = { DescriptionBox.Text, QuantityBox.Text, ValueBox.Text, TotalValue.ToString() };
                    try
                    {
                        // Tries fill the ListView with the values typed
                        UpdateFields.FillList(RegTable, row);
                    }
                    catch (Exception error)
                    {
                        // If the fill fails, the Application shows a message error
                        MessageBox.Show(error.Message, "Cadogress", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Updating the Total Fields
                    UpdateFields.UpdateValue(RegTable, TotalValueSumBox);
                    UpdateFields.UpdateQuantity(RegTable, QuantitySumBox);
                }
                else
                {
                    // If the fields were typed with a non-numeric value, the Application shows the message below
                    MessageBox.Show("Os campos de Quantidade e Valor devem ser numéricos!", "Cadogress", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If any field wasn't filled,  the Application shows the message below
                MessageBox.Show("Favor preencher todos os campos!", "Cadogress", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RegTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Removes the selected data row in a double click
            RegTable.SelectedItems[0].Remove();

            // Updating the Total Fields
            UpdateFields.UpdateValue(RegTable, TotalValueSumBox);
            UpdateFields.UpdateQuantity(RegTable, QuantitySumBox);
        }
    }
}
