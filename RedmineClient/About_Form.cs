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
    public partial class About_Form : Form
    {
        public About_Form()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        // The image on about form was found in google images.
        // The license terms where taken from https://opensource.org/licenses/BSD-3-Clause.
        // Icons:
        // exit icon: https://all-psd.ru/icons-set/75-ikonka-udalit.html
        // about icon: http://ru.gofreedownload.net/free-icon/icons/sign-info-109115/#.WUIutFXyiUk
        // settings icon: http://iconbird.com/view/23174_iconki_Control_Panel_panel_upravleniya_nastroyki_shesterenka

    }
}