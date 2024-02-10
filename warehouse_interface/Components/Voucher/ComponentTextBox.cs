using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace warehouse_interface.Components
{
    public class ComponentTextBox
    {
        public void TextBoxAutocomplete(List<String> receiptAll, TextBox receipt)
        {
            AutoCompleteStringCollection autoCompleteStringCollectionReceipt = new AutoCompleteStringCollection();

            autoCompleteStringCollectionReceipt.AddRange(receiptAll.ToArray());

            receipt.AutoCompleteMode = AutoCompleteMode.Suggest;
            receipt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            receipt.AutoCompleteCustomSource = autoCompleteStringCollectionReceipt;
        }
    }
}
