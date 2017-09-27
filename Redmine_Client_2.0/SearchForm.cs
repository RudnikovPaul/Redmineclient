using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Redmine_Client_2._0
{
    public partial class SearchForm : Form
    {
        private string OldNumber = "";
        private string NewNumber = "";

        Thread AsynchronousSearchThread;

        public SearchForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ResultForSearchLabel.TextAlign = ContentAlignment.MiddleCenter;
            AsynchronousSearchThread = new Thread(AsynchronousSearch);
            AsynchronousSearchThread.Start();
        }

        private void SearchTaskTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptButton.Enabled = false;
            ErrorLabel.Text = "Only numbers";
            ErrorLabel.Visible = false;
            char number = e.KeyChar;

            if (number == 13) Accept();

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
                ErrorLabel.Visible = true;
            }
            else if (SearchTaskTextBox.Text.Length == 8 && number != 8)
            {
                ErrorLabel.Text = "Max 8 digits";
                ErrorLabel.Visible = true;
                e.Handled = true;
            }            
        }

        private void TextChangedNow(object sender, EventArgs e)
        {
            NewNumber = SearchTaskTextBox.Text;
            ResultForSearchLabel.Text = "";
            AcceptButton.Enabled = false;
            pictureBox1.Visible = true;
        }

        private void AsynchronousSearch ()
        {
            while (true)
            {
                if (NewNumber != OldNumber)
                {                    
                    if (SearchTaskTextBox.Text.Length != 0) ResultForSearchLabel.Text = BuisinessLogicClass.NormalizeText(BuisinessLogicClass.FindIssue(Convert.ToInt32(SearchTaskTextBox.Text)), 30);
                    if (ResultForSearchLabel.Text.Length > 0) AcceptButton.Enabled = true;
                    else AcceptButton.Enabled = false;
                    OldNumber = NewNumber;
                    pictureBox1.Visible = false;
                }
                else Thread.Sleep(100);
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Accept();
        }

        private void Accept ()
        {
            BuisinessLogicClass.AddIssueByItsId(Convert.ToInt32(SearchTaskTextBox.Text));
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SearchForm_Closed(object sender, FormClosedEventArgs e)
        {
            AsynchronousSearchThread.Abort();
        }


    }
}
