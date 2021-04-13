using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDb.App
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            frmAddNewStu frm = new frmAddNewStu();
            frm.ShowDialog();
        }

        private void btnStuList_Click(object sender, EventArgs e)
        {
            frmStudentList frm = new frmStudentList();
            frm.ShowDialog();
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            frmUpdateDelete frm = new frmUpdateDelete();
            frm.ShowDialog();
        }

        
    }
}
