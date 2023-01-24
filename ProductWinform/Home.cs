using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductWinform
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.MdiParent = this;
            emp.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.MdiParent = this;
            std.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books b = new Books();
            b.MdiParent = this;
            b.Show();
        }

        private void disconnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.Show();
        }

        private void disconnectionEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisEmployee de = new DisEmployee();
            de.MdiParent = this;
            de.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void disConnectionBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDis BD = new BookDis();
            BD.MdiParent = this;
            BD.Show();
        }

        private void disConnectionStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDIS std = new StudentDIS();
            std.MdiParent = this;
            std.Show();

        }
    }
}
