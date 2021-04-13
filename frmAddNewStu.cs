using SchoolDb.App.Entities;
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
    public partial class frmAddNewStu : Form
    {
        SqlConnection con = new SqlConnection($"Data Source=CEREN\\SQLEXPRESS; Initial Catalog=SchoolDb; Integrated Security=true;");
        public frmAddNewStu()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection($"Data Source=CEREN\\SQLEXPRESS; Initial Catalog=SchoolDb; Integrated Security=true;");
            Student st = new Student()
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Address = rtxtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                ClassId = Convert.ToInt32(txtClassId.Text),
                No = Convert.ToInt16(txtNo.Text)
            };
 
            SqlCommand cmd = new SqlCommand($"Insert into Students (Name,Surname,Address,PhoneNumber,ClassId,No) values ('{st.Name}','{st.Surname}','{st.Address}','{st.PhoneNumber}','{st.ClassId}','{st.No}')",con);

            con.Open();

            int result= cmd.ExecuteNonQuery(); 

            if (result > 0)
            {
                MessageBox.Show("Mission Completed");
            }
            else
            {
                MessageBox.Show("---");
            }
            con.Close();

            this.Close();
        }
    }
}
