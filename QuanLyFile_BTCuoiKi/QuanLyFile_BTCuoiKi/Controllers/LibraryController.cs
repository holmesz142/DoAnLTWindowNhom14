using QuanLyFile_BTCuoiKi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace QuanLyFile_BTCuoiKi.Controllers
{
    public class LibraryController
    {
        public static bool AddToLibraRy(Library file)
        {
            try
            {
                using (var _context = new QuanLyFille_CuoiKiEntities2())
                {
                    _context.AddToLibrary(file.FileName, file.FilePath, file.Type);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        /*public static Library GetFile()
        {
            try
            {
                using (var _context = new QuanLyFille_CuoiKiEntities2())
                {
                    Library data = _context.GetAllFile1();
                    return data;
                }
            }
            catch
            {
                return false;
            }
        }*/


    }
}
