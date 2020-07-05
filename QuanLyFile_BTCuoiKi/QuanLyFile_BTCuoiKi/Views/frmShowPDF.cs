using QuanLyFile_BTCuoiKi.Controllers;
using QuanLyFile_BTCuoiKi.Models;
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

namespace QuanLyFile_BTCuoiKi.Views
{
    public partial class frmShowPDF : Form
    {
        public frmShowPDF()
        {
            InitializeComponent();
        }

        public string getFileName(string filePath)
        {
            string fileName = Path.GetFileName(filePath).ToString();

            return fileName;
        }

        public string getFilePath(string filePath)
        {
            string filepath = filePath;

            return filepath;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OpenFile(string fileName)
        {
            axAcroPDF1.src = fileName;
        }

        bool edit;
        private void btnSave_Click(object sender, EventArgs e)
        {
            Note note = new Note();

            note.FileName = this.Text.ToString();
            note.note = rtbNote.Text.ToString();

            NoteController.AddNote(note);

            NoteController.UpdateNote(note);
        }
    }
}
