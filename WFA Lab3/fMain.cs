using ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Lab3
{
    public partial class fMain : Form
    { 
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            fPhone fph = new fPhone(phone);
            if(fph.ShowDialog() == DialogResult.OK)
            {
                tbPhonesInfo.Text +=
                $"Модель: {phone.Model}\n " +
                $"Діагональ:{phone.Diagonal}\n " +
                $"Ядра: {phone.Cores}\n " +
                $"Платформа: {phone.Platform}\n " +
                $"Має ШІ: {(phone.HasAI ? "має штучний iнтелект" : "не має штучного iнтелекту")}\n " +
                $"Має TypeC:{(phone.HasTypeC ? "має typec" : "не має typec")}\n ";
            }

        }

        private void btnCloseClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
