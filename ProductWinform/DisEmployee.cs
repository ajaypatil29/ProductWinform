using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProductWinform
{
    public partial class DisEmployee : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommandBuilder SqlCommandBuilder;
        DataSet ds;

        public DisEmployee()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
        }
        private DataSet GetAll()
        {
            adapter = new SqlDataAdapter("Select*from tblEmployee", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "tblEmployee");
            return ds;

            
        }
        public void ClearAll()
        {
            txtName.Clear();
            txtAge.Clear();
            txtDept.Clear();

            txtSalary.Clear();
            txtId.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["tblEmployee"].NewRow();
                row["EName"] = txtName.Text;
                row["Edept"] = txtDept.Text;
                row["Salary"] = txtSalary.Text;
                row["Age"] = txtAge.Text;
                ds.Tables["tblEmployee"].Rows.Add(row);
                int result = adapter.Update(ds.Tables["tblEmployee"]);
                if(result==1)
                {
                    MessageBox.Show("Record saved"); ClearAll();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["tblEmployee"].Rows.Find(txtId.Text);
               
                if (row!=null)
                {
                    txtName.Text = row["EName"].ToString();
                    txtDept.Text = row["Edept"].ToString();
                    txtAge.Text = row["Age"].ToString();
                    txtSalary.Text = row["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found");
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
                DataRow row = ds.Tables["tblEmployee"].Rows.Find(txtId.Text);

                if (row != null)
                {
                    row["EName"] = txtName.Text;
                    row["Edept"] = txtDept.Text;
                    row["Age"] = txtAge.Text;
                    row["Salary"] = txtSalary.Text;
                    int result = adapter.Update(ds.Tables["tblEmployee"]);
                    if(result==1)
                    {
                        MessageBox.Show("Record Updated"); ClearAll();
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found");
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
                DataRow row = ds.Tables["tblEmployee"].Rows.Find(txtId.Text);

                if (row != null)
                {
                    row.Delete();
                    int result = adapter.Update(ds.Tables["tblEmployee"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record deleted"); ClearAll();
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found");
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
                TBLShowAll.DataSource = ds.Tables["tblEmployee"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
