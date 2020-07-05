using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyFile_BTCuoiKi.Models;


namespace QuanLyFile_BTCuoiKi.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openChildForm(new frmLibrary());
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLibrary());
        }

       

        private void btnNote_Click(object sender, EventArgs e)
        {
            openChildForm(new frmShowNote());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHistory());
        }
    }
}
