using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace ProductWinform
{
    public partial class Student : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Student()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
        }
        public void ClearMethod()
        {
            txtAge.Clear();
            txtName.Clear();
            txtpercentage.Clear();
            txtRollno.Clear();
            cbGender.ResetText();
            cbSteam.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into student values(@name,@Stream,@Per,@age,@gender)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@Stream", cbSteam.SelectedItem);
                cmd.Parameters.AddWithValue("@Per", Convert.ToDecimal(txtpercentage.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@gender", cbGender.SelectedItem);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if(result==1)
                {
                    if (result == 1)
                    {
                        MessageBox.Show("Record Added");
                        ClearMethod();
                    }
                }
             
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "Update student set Name=@name,Stream=@Stream,per=@Per,age=@age,gender=@gender where Rollno=@Rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@Stream", cbSteam.SelectedItem);
                cmd.Parameters.AddWithValue("@Per", Convert.ToDecimal(txtpercentage.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@gender", cbGender.SelectedItem);
                cmd.Parameters.AddWithValue("@Rollno", Convert.ToInt32(txtRollno.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    if (result == 1)
                    {
                        MessageBox.Show("Record Updated");
                        ClearMethod();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select*from student where Rollno=@Rollno";
                cmd = new SqlCommand(qry, con);
             
                cmd.Parameters.AddWithValue("@Rollno", Convert.ToInt32(txtRollno.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        txtRollno.Text = dr["Rollno"].ToString();
                        txtName.Text = dr["Name"].ToString();
                        txtpercentage.Text = dr["per"].ToString();
                        txtAge.Text = dr["age"].ToString();
                        cbSteam.SelectedItem=dr["Stream"].ToString();
                        cbGender.SelectedItem = dr["gender"].ToString();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Delete from student where Rollno=@Rollno";
                cmd = new SqlCommand(qry, con);
       
                cmd.Parameters.AddWithValue("@Rollno", Convert.ToInt32(txtRollno.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    if (result == 1)
                    {
                        MessageBox.Show("Record Deleted");
                        ClearMethod();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select*from student ";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    TBLShowAll.DataSource = table;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
