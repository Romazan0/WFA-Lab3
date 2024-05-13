using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace WFA_Lab3
{
    public partial class fPhone : Form
    {
        public Phone phone = new Phone();
        public fPhone(Phone t)
        {
            phone = t;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            phone.Model = tbModel.Text.Trim();
            phone.Diagonal = tbDiagonal.Text.Trim();
            phone.Cores = int.Parse(tbCores.Text.Trim());
            phone.Platform = tbPlatform.Text.Trim();
            phone.SimQuantity = int.Parse(tbSimQuantity.Text.Trim());
            phone.HasAI = chbHasAI.Checked;
            phone.HasTypeC = chbHasTypeC.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fPhone_Load(object sender, EventArgs e)
        {
            if (phone != null)
            {
                tbModel.Text = phone.Model;
                tbDiagonal.Text = phone.Diagonal;
                tbCores.Text = phone.Cores.ToString();
                tbPlatform.Text = phone.Platform;
                tbSimQuantity.Text = phone.SimQuantity.ToString();
                chbHasAI.Checked = phone.HasAI;
                chbHasTypeC.Checked = phone.HasTypeC;
            }

        }
    }
}
