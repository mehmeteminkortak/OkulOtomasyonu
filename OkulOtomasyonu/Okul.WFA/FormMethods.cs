using Okul.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul.WFA
{
    public static class FormMethods
    {
        public static void FormTemizle(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = -1;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is MaskedTextBox)
                    item.Text = string.Empty;
            }
        }
        public static void ListeyiDoldur<T>(ListBox lst, List<T> liste) where T : Insan
        {
            lst.Items.Clear();
            foreach (T item in liste)
            {
                lst.Items.Add(item);
            }
        }
    }
}
