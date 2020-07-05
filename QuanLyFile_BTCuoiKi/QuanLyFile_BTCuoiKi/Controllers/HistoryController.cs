using QuanLyFile_BTCuoiKi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyFile_BTCuoiKi.Controllers
{
    public class HistoryController
    {
        public static bool AddHistory(History note)
        {
            try
            {
                using (var _context = new QuanLyFille_CuoiKiEntities2())
                {
                    _context.SaveTime(note.FilePath, note.TimeOpen);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateHistory(History note)
        {
            try
            {
                using (var _context = new QuanLyFille_CuoiKiEntities2())
                {
                    _context.UpdateHistory(note.FilePath, note.FilePath, note.TimeOpen);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
