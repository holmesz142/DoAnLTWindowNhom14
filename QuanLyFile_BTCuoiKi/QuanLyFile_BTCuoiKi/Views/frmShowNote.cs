using QuanLyFile_BTCuoiKi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyFile_BTCuoiKi.Views
{
    public partial class frmShowNote : Form
    {
        public frmShowNote()
        {
            InitializeComponent();

            this.cFileName.DataPropertyName = nameof(Note.FileName);
            this.cNote.DataPropertyName = nameof(Note.note);


            showNote(dgvShowNote);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showNote(DataGridView dgv)
        {
            QuanLyFille_CuoiKiEntities2 qlf = new QuanLyFille_CuoiKiEntities2();
            dgv.DataSource = qlf.GetNote();
        }

        private void dgvShowNote_DoubleClick(object sender, EventArgs e)
        {
            string filePath = dgvShowNote.CurrentCell.Value.ToString();

            string extension = System.IO.Path.GetExtension(filePath);
            if (extension == ".txt")
            {
                frmShowTxt frmShowtxt = new frmShowTxt();
                frmShowtxt.OpenFile(filePath);
                frmShowtxt.Text = filePath.ToString();
                frmShowtxt.Show();
            }
            if (extension == ".doc" || extension == ".docx")
            {

                frmShowWord frmWord = new frmShowWord();
                frmWord.OpenFile(filePath);
                frmWord.Text = filePath.ToString();
                
                frmWord.Show();
            }
            if (extension == ".pdf")
            {
                frmShowPDF frmPDF = new frmShowPDF();
                frmPDF.OpenFile(filePath);
                frmPDF.Text = filePath.ToString();
                
                frmPDF.Show();
            }


        }
    }
}
