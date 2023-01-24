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
    public partial class BookDis : Form
    {
        SqlConnection con;
        SqlCommandBuilder SqlCommandBuilder;SqlDataAdapter adapter;
        DataSet ds;

        public BookDis()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

        }
        private DataSet GetAll()
        {
            adapter = new SqlDataAdapter("Select*from Book", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "Book");
            return ds;

        }
        public void ClearAll()
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
                ds = GetAll();
                DataRow row = ds.Tables["Book"].NewRow();
                row["Bname"] = txtName.Text;
                row["Price"] = txtPrice.Text;
                row["Author"] = txtAuthor.Text;
                row["edition"] = txtEdition.Text;
                row["publication"] = txtPublication.Text;
                ds.Tables["Book"].Rows.Add(row);
                int result = adapter.Update(ds.Tables["Book"]);
                if (result == 1)
                {
                    MessageBox.Show("Record Inserted"); ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["Book"].Rows.Find(txtID.Text);
             
               
                if (row!=null)
                {
                    txtName.Text = row["Bname"].ToString();
                    txtPrice.Text = row["Price"].ToString();
                    txtAuthor.Text = row["Author"].ToString();
                    txtEdition.Text = row["edition"].ToString();
                    txtPublication.Text = row["publication"].ToString();
                    
                    
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["Book"].Rows.Find(txtID.Text); ClearAll();


                if (row != null)
                {
                    row["Bname"] = txtName.Text;
                    row["Price"] = txtPrice.Text;
                    row["Author"] = txtAuthor.Text;
                    row["edition"] = txtEdition.Text;
                    row["publication"] = txtPublication.Text;
                    int result = adapter.Update(ds.Tables["Book"]);
                    if(result==1)
                    {
                        MessageBox.Show("Record Updated");
                    }

                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["Book"].Rows.Find(txtID.Text);


                if (row != null)
                {
                    row.Delete();
                    int result = adapter.Update(ds.Tables["Book"]);
                    if(result==1)
                    {
                        MessageBox.Show("Record Deleted"); ClearAll();
                    }

                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                TBLShowAll.DataSource = ds.Tables["Book"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
