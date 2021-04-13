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
    public partial class frmUpdateDelete : Form
    {
        public Student ChoosenOne { get; set; }

        SqlConnection con = new SqlConnection("Data Source=CEREN\\SQLEXPRESS; Initial Catalog=SchoolDb; Integrated Security=true;");
        public frmUpdateDelete()
        {
            InitializeComponent();
        }

        private void frmUpdateDelete_Load(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            SqlCommand cmd = new SqlCommand("Select * from Students", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader(); //SqlDataReader dönüyor

            while (rd.Read()) //Okunacak veriler olduğu sürece devam ediyor
            {
                Student s = new Student();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ChoosenOne = (Student)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                txtName.Text = ChoosenOne.Name;
                txtSurname.Text = ChoosenOne.Surname;
                rtxtAddress.Text = ChoosenOne.Address;
                txtPhoneNumber.Text = ChoosenOne.PhoneNumber;
                txtNo.Text = ChoosenOne.No.ToString();
                txtClassId.Text = ChoosenOne.ClassId.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong click!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"Delete from Students where Id={ChoosenOne.Id}", con);

            con.Open(); //VS ile veri tabanı arası bağlantı
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Process completed successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect process, try again.");
            }

            con.Close();
            this.Visible = false;
            frmUpdateDelete frm = new frmUpdateDelete();
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            Student st = new Student
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Address = rtxtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                ClassId = Convert.ToInt32(txtClassId.Text),
                No = Convert.ToInt16(txtNo.Text)
            };

            SqlCommand com = new SqlCommand($"Update Students set Name='{st.Name}',Surname='{st.Surname}',Address='{st.Address}',PhoneNumber='{st.PhoneNumber}', ClassId ='{st.ClassId}',No='{st.No}' where Id={ChoosenOne.Id}",con);

            con.Open();

            if (com.ExecuteNonQuery() > 0)
            {
               
                MessageBox.Show("Process completed successfully.");
            }
            else
            {
                MessageBox.Show("Incorrect process, try again.");
            }
            //yeni listeyi göster
            SqlCommand cmd2 = new SqlCommand("Select * from Students", con);
            SqlDataReader rd = cmd2.ExecuteReader();
            while (rd.Read())
            {
                Student s = new Student();
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
