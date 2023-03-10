
namespace ProductWinform
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectionEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disConnectionBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disConnectionStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.disconnectionToolStripMenuItem,
            this.disconnectionEmployeeToolStripMenuItem,
            this.disConnectionBookToolStripMenuItem,
            this.disConnectionStudentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // disconnectionToolStripMenuItem
            // 
            this.disconnectionToolStripMenuItem.Name = "disconnectionToolStripMenuItem";
            this.disconnectionToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.disconnectionToolStripMenuItem.Text = "Disconnection Product";
            this.disconnectionToolStripMenuItem.Click += new System.EventHandler(this.disconnectionToolStripMenuItem_Click);
            // 
            // disconnectionEmployeeToolStripMenuItem
            // 
            this.disconnectionEmployeeToolStripMenuItem.Name = "disconnectionEmployeeToolStripMenuItem";
            this.disconnectionEmployeeToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.disconnectionEmployeeToolStripMenuItem.Text = "Disconnection employee";
            this.disconnectionEmployeeToolStripMenuItem.Click += new System.EventHandler(this.disconnectionEmployeeToolStripMenuItem_Click);
            // 
            // disConnectionBookToolStripMenuItem
            // 
            this.disConnectionBookToolStripMenuItem.Name = "disConnectionBookToolStripMenuItem";
            this.disConnectionBookToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.disConnectionBookToolStripMenuItem.Text = "DisConnection Book";
            this.disConnectionBookToolStripMenuItem.Click += new System.EventHandler(this.disConnectionBookToolStripMenuItem_Click);
            // 
            // disConnectionStudentToolStripMenuItem
            // 
            this.disConnectionStudentToolStripMenuItem.Name = "disConnectionStudentToolStripMenuItem";
            this.disConnectionStudentToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.disConnectionStudentToolStripMenuItem.Text = "DisConnection Student";
            this.disConnectionStudentToolStripMenuItem.Click += new System.EventHandler(this.disConnectionStudentToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectionEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disConnectionBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disConnectionStudentToolStripMenuItem;
    }
}