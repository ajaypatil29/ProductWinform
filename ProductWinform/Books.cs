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
    public partial class Books : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Books()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
        }
        public void ClearMethod()
        {
            txtAuthor.Clear();
            txtEdition.Clear();
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtPublication.Clear();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into book values(@name,@Price,@Author,@edition,@publication)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@edition", txtEdition.Text);
                cmd.Parameters.AddWithValue("@publication", txtPublication.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record Added");
                    ClearMethod();

                }
            }
            catch(Exception ex)
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
                string qry = "update book set Bname=@name,Price=@Price,Author=@Author,edition=@edition,publication=@publication where ID=@ID";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@edition", txtEdition.Text);
                cmd.Parameters.AddWithValue("@publication", txtPublication.Text);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record updated");
                    ClearMethod();
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
                string qry = "Select*from book where Id=@ID";
                cmd = new SqlCommand(qry, con);
              
                cmd.Parameters.AddWithValue("@ID",Convert.ToInt32 ( txtID.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if(dr.Read())
                    {
                        txtID.Text = dr["Id"].ToString();
                        txtName.Text = dr["Bname"].ToString();
                        txtEdition.Text = dr["edition"].ToString();
                        txtAuthor.Text = dr["Author"].ToString();
                        txtPrice.Text = dr["Price"].ToString();
                        txtPublication.Text = dr["publication"].ToString();

                    }
                    
                }
                else
                {
                    MessageBox.Show("NO record found");
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
                string qry = "Delete from book where Id=@Id";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record deleted");
                    ClearMethod();
                    
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
                string qry = "Select*from book ";
                cmd = new SqlCommand(qry, con);

                
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    TBLShowAll.DataSource = table;

                }
                else
                {
                    MessageBox.Show("NO record found");
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
