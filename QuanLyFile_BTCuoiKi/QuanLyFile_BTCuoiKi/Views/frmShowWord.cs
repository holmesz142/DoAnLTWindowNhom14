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
using Word = Microsoft.Office.Interop.Word;

namespace QuanLyFile_BTCuoiKi.Views
{
    public partial class frmShowWord : Form
    {

        QuanLyFille_CuoiKiEntities2 qlf = new QuanLyFille_CuoiKiEntities2();

        
        public frmShowWord()
        {
            InitializeComponent();


           
        }

       
        
        public void OpenFile(string fileName)
        {
            
            Word.Document document;
            Word.Application application = new Word.Application();
            document = application.Documents.Open(fileName);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            IDataObject dataObject = Clipboard.GetDataObject();
            rtbRead.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
            /*string frmName = fileName.ToString();
            rtbNote.Text = NoteController.showNote(frmName);*/
            application.Quit();
        }

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
