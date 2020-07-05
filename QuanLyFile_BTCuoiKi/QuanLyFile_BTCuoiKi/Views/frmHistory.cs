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
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
            this.cFilePath.DataPropertyName = nameof(History.FilePath);
            this.cTime.DataPropertyName = nameof(History.TimeOpen);



            showTime(dataGridView1);
        }
        private void showTime(DataGridView dgv)
        {
            QuanLyFille_CuoiKiEntities2 qlf = new QuanLyFille_CuoiKiEntities2();
            dgv.DataSource = qlf.GetTime();
        }
    }
}
