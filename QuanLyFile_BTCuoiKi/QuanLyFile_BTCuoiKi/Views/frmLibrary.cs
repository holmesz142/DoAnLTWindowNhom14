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
using QuanLyFile_BTCuoiKi.Controllers;
using QuanLyFile_BTCuoiKi.Models;
using QuanLyFile_BTCuoiKi.Views;

namespace QuanLyFile_BTCuoiKi.Views
{
    public partial class frmLibrary : Form
    {

        OpenFileDialog open;
        Library file = new Library();
        List<Library> listFile;

        public frmLibrary()
        {
            InitializeComponent();

            this.cName.DataPropertyName = nameof(Library.FileName);
            this.cPath.DataPropertyName = nameof(Library.FilePath);
            this.cType.DataPropertyName = nameof(Library.Type);

            showFile(dataGridViewLibrary);

            
        }
 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            open = new OpenFileDialog();
            open.Filter = "All files (*.*)|*.*";
            Library file = new Library();

            if (open.ShowDialog() == DialogResult.OK)
            {
                
                file.FilePath = open.FileName.ToString();
                file.FileName = Path.GetFileName(open.FileName).ToString();
                file.Type = Path.GetExtension(file.FilePath).ToString();
            }

            LibraryController.AddToLibraRy(file);
            

            showFile(dataGridViewLibrary);
            

        }

        private void showFile(DataGridView dgv)
        {
            QuanLyFille_CuoiKiEntities2 qlf = new QuanLyFille_CuoiKiEntities2();
            dgv.DataSource = qlf.GetAllFile1();
            //dgv.DataSource = LibraryController.GetFile();
        }

        private void showFileTxt(DataGridView dgv)
        {
            QuanLyFille_CuoiKiEntities2 qlf = new QuanLyFille_CuoiKiEntities2();
            dgv.DataSource = qlf.GetFileTxt();
        }
        private void showFileWord(DataGridView dgv)
        {
            QuanLyFille_CuoiKiEntities2 qlf = new QuanLyFille_CuoiKiEntities2();
            dgv.DataSource = qlf.GetFileWord();
        }
        private void showFilePdf(DataGridView dgv)
        {
            QuanLyFille_CuoiKiEntities2 qlf = new QuanLyFille_CuoiKiEntities2();
            dgv.DataSource = qlf.GetFilePdf();
        }



        private void btnOpen_Click(object sender, EventArgs e)
        {
            History fileNearOpen = new History();
            string filePath = dataGridViewLibrary.CurrentCell.Value.ToString();
            string extension = System.IO.Path.GetExtension(filePath);
            if(extension == ".txt")
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


            fileNearOpen.FilePath = filePath.ToString();
            fileNearOpen.TimeOpen = DateTime.Now;

            HistoryController.AddHistory(fileNearOpen);

            HistoryController.UpdateHistory(fileNearOpen);

        }

      
        private void frmLibrary_Load(object sender, EventArgs e)
        {    
            
        }



       

        private void dataGridViewLibrary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Library file = new Library();

            if (this.dataGridViewLibrary.CurrentRow.Cells[0].Value == null)
            {
                this.dataGridViewLibrary.CurrentRow.Cells[0].Value = "";
            }
            if (this.dataGridViewLibrary.CurrentRow.Cells[1].Value == null)
            {
                this.dataGridViewLibrary.CurrentRow.Cells[1].Value = "";
            }

            try
            {
                file.FileName = this.dataGridViewLibrary.CurrentRow.Cells[0].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Nhập file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbType.Text == "Text File (.txt)")
            {
                this.showFileTxt(dataGridViewLibrary);
            }
            if (cbType.Text == "Word File (.docx)")
            {
                this.showFileWord(dataGridViewLibrary);
            }
            if (cbType.Text == "PDF File (.pdf)")
            {
                this.showFilePdf(dataGridViewLibrary);
            }
            if (cbType.Text == "All File (.*)")
            {
                this.showFile(dataGridViewLibrary);
            }
        }
    }
}
