using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaviTestApplication
{
    public partial class PaymentDetail : Form
    {
        public PaymentDetail()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\Users\\Admin\\Documents\\Company\\PaymentDetails.txt");
            txt.Write("ApplicationId: 197104, Type: "  + cmbType.SelectedItem.ToString() + ", Summary: " + cmbSummary.SelectedItem.ToString() + ", Amount: " + txtAmount.Text + ", PastingDate: " + dtpPostingDate.Text + ", IsCleared: " + chkIsCleared.Checked + ", ClearedDate: " + dtpClearedDate.Text);
            txt.Close();
        }
    }
}
