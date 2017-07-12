using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedmineClient
{
    public partial class SearchOthersForm : Form
    {
        private string taskNumberToSearchFor;

        public SearchOthersForm()
        {
            InitializeComponent();
            ResultForSearchLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SearchTaskTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            FindResultLabel.Visible = false;
            ErrorLabel.Text = "Only numbers";
            ErrorLabel.Visible = false;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
                ErrorLabel.Visible = true;
            }
            else if (SearchTaskTextBox.Text.Length == 10 && number != 8)
            {
                ErrorLabel.Text = "Max 10 digits";
                ErrorLabel.Visible = true;
                e.Handled = true;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ResultForSearchLabel.Text = "The result gets hear and may be big";
            taskNumberToSearchFor = SearchTaskTextBox.Text;
            ErrorLabel.Visible = false;
            FindResultLabel.Visible = true;
        }
    }
}
