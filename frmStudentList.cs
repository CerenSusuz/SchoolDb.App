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
    public partial class frmStudentList : Form
    {
        public frmStudentList()
        {
            InitializeComponent();
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            SqlConnection con = new SqlConnection("Data Source=CEREN\\SQLEXPRESS; Initial Catalog=SchoolDb; Integrated Security= true;");
            SqlCommand cmd = new SqlCommand("Select * from Students",con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader(); //SqlDataReader dönüyor
            
            while (rd.Read()) //Okunacak veriler olduğu sürece devam ediyor, bool dönüyor
            {
                Student s = new Student(); //keylerle valuelara ulaşıyor
                s.Id = Convert.ToInt32(rd["Id"]);
                s.Name = rd["Name"].ToString();
                s.Surname = rd["Surname"].ToString();
                s.PhoneNumber = rd["PhoneNumber"].ToString();
                s.Address = rd["Address"].ToString();
                s.ClassId = Convert.ToInt32(rd["ClassId"]);
                s.No = Convert.ToInt16(rd["No"]);

                students.Add(s);
           
            }

            con.Close();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;


        }
    }
}
