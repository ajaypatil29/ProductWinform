
namespace ProductWinform
{
    partial class DisEmployee
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
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.TBLShowAll = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.llbDept = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TBLShowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(62, 157);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 48;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(204, 154);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(195, 22);
            this.txtAge.TabIndex = 47;
            // 
            // TBLShowAll
            // 
            this.TBLShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TBLShowAll.Location = new System.Drawing.Point(65, 246);
            this.TBLShowAll.Name = "TBLShowAll";
            this.TBLShowAll.RowHeadersWidth = 51;
            this.TBLShowAll.RowTemplate.Height = 24;
            this.TBLShowAll.Size = new System.Drawing.Size(674, 150);
            this.TBLShowAll.TabIndex = 46;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(300, 402);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(176, 37);
            this.btnShowAll.TabIndex = 45;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(75, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(190, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(488, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 37);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(204, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 22);
            this.txtName.TabIndex = 41;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(204, 75);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(195, 22);
            this.txtDept.TabIndex = 40;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(204, 113);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(195, 22);
            this.txtSalary.TabIndex = 39;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(62, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 17);
            this.lblId.TabIndex = 38;
            this.lblId.Text = "Employee Id";
            // 
            // llbDept
            // 
            this.llbDept.AutoSize = true;
            this.llbDept.Location = new System.Drawing.Point(65, 75);
            this.llbDept.Name = "llbDept";
            this.llbDept.Size = new System.Drawing.Size(82, 17);
            this.llbDept.TabIndex = 37;
            this.llbDept.Text = "Department";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(62, 116);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(114, 17);
            this.lblSal.TabIndex = 36;
            this.lblSal.Text = "Employee Salary";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(62, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 17);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Employee Name";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(204, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(195, 22);
            this.txtId.TabIndex = 34;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(300, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DisEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.TBLShowAll);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.llbDept);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Name = "DisEmployee";
            this.Text = "DisEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.TBLShowAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DataGridView TBLShowAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label llbDept;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDelete;
    }
}