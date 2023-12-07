using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerBar
{
    public static class Software_Functions
    {
        public static void ChangeStateTextBox(Guna2Separator guna2Separator, Guna2TextBox guna2TextBox)
        {
            if (guna2TextBox.Focused)
            {
                guna2Separator.FillColor = Color.Green;
                guna2Separator.FillThickness = 2;
            }
            else
            {
                guna2Separator.FillColor = Color.Gray;
                guna2Separator.FillThickness = 1;
            }
        }
        public static void ChangeStateComboBox(Guna2Separator guna2Separator, Guna2ComboBox guna2ComboBox)
        {
            if (guna2ComboBox.Focused)
            {
                guna2Separator.FillColor = Color.Green;
                guna2Separator.FillThickness = 2;
            }
            else
            {
                guna2Separator.FillColor = Color.Gray;
                guna2Separator.FillThickness = 1;
            }
        }
    }
}
