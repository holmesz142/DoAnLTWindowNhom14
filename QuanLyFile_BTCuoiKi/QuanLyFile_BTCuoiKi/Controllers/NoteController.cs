using QuanLyFile_BTCuoiKi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyFile_BTCuoiKi.Controllers
{
    public class NoteController
    {
        public static bool AddNote(Note note)
        {
            try
            {
                using (var _context = new QuanLyFille_CuoiKiEntities2())
                {
                    _context.AddNotes(note.FileName, note.note);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateNote(Note note)
        {
            try
            {
                using (var _context = new QuanLyFille_CuoiKiEntities2())
                {
                    _context.UpdateNote(note.FileName, note.FileName, note.note);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

       

        public static string showNote(string fileName)
        {
            using (var _context = new QuanLyFille_CuoiKiEntities2())
            {
               var notes = _context.ShowNote1(fileName, fileName).ToString();

                return notes;
            }
        }
        
    }
}
