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
    
    public partial class StudentDIS : Form
    {
        SqlConnection con;
        SqlDataAdapter Adapter;
        SqlCommandBuilder SqlCommandBuilder;
        DataSet ds;
        public StudentDIS()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
        }
        private DataSet GetAll()
        {
            Adapter = new SqlDataAdapter("Select *from Student", con);
            Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder = new SqlCommandBuilder(Adapter);
            ds = new DataSet();
            Adapter.Fill(ds, "Student");
            return ds;

        }
        public void ClearAll()
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
                ds = GetAll();
                DataRow row = ds.Tables["Student"].NewRow();
                row["Name"] = txtName.Text;
                row["Stream"] = cbSteam.SelectedItem;
                row["per"] = txtpercentage.Text;
                row["age"] = txtAge.Text;
                row["gender"] = cbGender.SelectedItem;
                ds.Tables["Student"].Rows.Add(row);
                int result = Adapter.Update(ds.Tables["Student"]);
                if(result==1)
                {
                    MessageBox.Show("Record inserted");
                    ClearAll();
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
                DataRow row = ds.Tables["Student"].Rows.Find(txtRollno.Text);
           
                
                if (row!=null)
                {
                    txtName.Text = row["Name"].ToString();
                    cbSteam.SelectedItem = row["Stream"].ToString();
                    txtpercentage.Text = row["per"].ToString();
                    txtAge.Text = row["age"].ToString();
                    cbGender.SelectedItem = row["gender"].ToString();
                   
                }
                else
                {
                    MessageBox.Show("Record Not found");
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
                DataRow row = ds.Tables["Student"].Rows.Find(txtRollno.Text);


                if (row != null)
                {
                    row["Name"] = txtName.Text;
                    row["Stream"] = cbSteam.SelectedItem;
                    row["per"] = txtpercentage.Text;
                    row["age"] = txtAge.Text;
                    row["gender"] = cbGender.SelectedItem;
                    int result = Adapter.Update(ds.Tables["Student"]);
                    if(result==1)
                    {
                        MessageBox.Show("Record Updated"); ClearAll();
                    }

                }
                else
                {
                    MessageBox.Show("Record Not Found");
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
                DataRow row = ds.Tables["Student"].Rows.Find(txtRollno.Text);


                if (row != null)
                {
                    row.Delete();
                    int result = Adapter.Update(ds.Tables["Student"]);
                    if(result==1)
                    {
                        MessageBox.Show("Record Deleted"); ClearAll();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Record Not Found");
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
                TBLShowAll.DataSource = ds.Tables["Student"];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
