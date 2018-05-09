using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadogress
{
    class UpdateFields // This class is used to Update some fields in ListView
    {
        public static void UpdateValue(ListView List, TextBox Receptor)
        // Updates the Total Value of ListView
        {
            Receptor.Text = "";
            foreach (ListViewItem row in List.Items)
            {
                // Foreach line in ListView, this loop sums the last column in ListView
                if (Receptor.Text != "") Receptor.Text = (double.Parse(Receptor.Text) + double.Parse(row.SubItems[3].Text)).ToString();
                else Receptor.Text = row.SubItems[3].Text;
            }
        }

        public static void UpdateQuantity(ListView List, TextBox Quantity)
        // Updates the Total Quantity Value of ListView
        {
            Quantity.Text = "";
            foreach (ListViewItem row in List.Items)
            {
                // Foreach line in ListView, this loop sums the second column in ListView
                if (Quantity.Text != "") Quantity.Text = (double.Parse(Quantity.Text) + double.Parse(row.SubItems[1].Text)).ToString();
                else Quantity.Text = row.SubItems[1].Text;
            }
        }

        public static double getTotalValue(string Snum1, string Snum2)
            // This function multiplies two string numeric values, and returns the result
        {
            double firstProd = Convert.ToDouble(Snum1);
            // Converting the strings into double variables
            double secondProd = Convert.ToDouble(Snum2);
            return firstProd * secondProd;
        }

        public static void FillList(ListView List, string [] items)
        {
            var insertionRow = new ListViewItem(items);
            List.Items.Add(insertionRow);
        }
    }
}
