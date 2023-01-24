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
    public partial class Form5 : Form
    {
        SqlConnection con;
        SqlDataAdapter Adapter;
        SqlCommandBuilder SqlCommandBuilder;
        DataSet ds;

        public Form5()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

        }
        private DataSet GetAll()
        {
            Adapter = new SqlDataAdapter("Select*from Product",con);
            Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder = new SqlCommandBuilder(Adapter);
            ds = new DataSet();
            Adapter.Fill(ds, "Product");//"Product" is name we can change
            return ds;
        }
        public void ClearAll()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtCompanyName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["Product"].NewRow();
                row["Proname"] = txtName.Text;
                row["price"] = txtPrice.Text;
                row["CompnanyName"] = txtCompanyName.Text;
                ds.Tables["Product"].Rows.Add(row);
                int result = Adapter.Update(ds.Tables["Product"]);
                if(result==1)
                {
                    MessageBox.Show("Record inserted"); ClearAll();
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
                DataRow row = ds.Tables["product"].Rows.Find(txtId.Text);
                if (row!=null)
                {
                    txtName.Text = row["Proname"].ToString();
                    txtPrice.Text = row["price"].ToString();
                    txtCompanyName.Text = row["CompnanyName"].ToString();
                    
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["product"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row["Proname"] = txtName.Text;
                    row["price"] = txtPrice.Text;
                    row["CompnanyName"] = txtCompanyName.Text;
                    int result=Adapter.Update(ds.Tables["Product"]);
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
                DataRow row = ds.Tables["product"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = Adapter.Update(ds.Tables["Product"]);
                    if(result==1)
                    {
                        MessageBox.Show("Record deleted"); ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Record not found");
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
                TBLShowAll.DataSource = ds.Tables["Product"];
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TBLShowAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
