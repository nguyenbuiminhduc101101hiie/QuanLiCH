namespace QuanLiCH.Admin
{
    partial class frmBill
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
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dtgkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtgkFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnBillwiew = new System.Windows.Forms.Button();
            this.btnFristBillPage = new System.Windows.Forms.Button();
            this.btnPreviousBillPage = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txbPageBill = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(78, 62);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(584, 341);
            this.dtgvBill.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dtgkToDate);
            this.panel12.Controls.Add(this.dtgkFromDate);
            this.panel12.Controls.Add(this.btnBillwiew);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(720, 31);
            this.panel12.TabIndex = 2;
            // 
            // dtgkToDate
            // 
            this.dtgkToDate.Location = new System.Drawing.Point(472, 4);
            this.dtgkToDate.Name = "dtgkToDate";
            this.dtgkToDate.Size = new System.Drawing.Size(200, 20);
            this.dtgkToDate.TabIndex = 2;
            // 
            // dtgkFromDate
            // 
            this.dtgkFromDate.Location = new System.Drawing.Point(7, 4);
            this.dtgkFromDate.Name = "dtgkFromDate";
            this.dtgkFromDate.Size = new System.Drawing.Size(205, 20);
            this.dtgkFromDate.TabIndex = 1;
            // 
            // btnBillwiew
            // 
            this.btnBillwiew.Location = new System.Drawing.Point(277, 4);
            this.btnBillwiew.Name = "btnBillwiew";
            this.btnBillwiew.Size = new System.Drawing.Size(144, 27);
            this.btnBillwiew.TabIndex = 0;
            this.btnBillwiew.Text = "Doanh Thu";
            this.btnBillwiew.UseVisualStyleBackColor = true;
            // 
            // btnFristBillPage
            // 
            this.btnFristBillPage.Location = new System.Drawing.Point(7, 436);
            this.btnFristBillPage.Name = "btnFristBillPage";
            this.btnFristBillPage.Size = new System.Drawing.Size(93, 22);
            this.btnFristBillPage.TabIndex = 3;
            this.btnFristBillPage.Text = "Frist";
            this.btnFristBillPage.UseVisualStyleBackColor = true;
            this.btnFristBillPage.Click += new System.EventHandler(this.btnFristBillPage_Click);
            // 
            // btnPreviousBillPage
            // 
            this.btnPreviousBillPage.Location = new System.Drawing.Point(115, 436);
            this.btnPreviousBillPage.Name = "btnPreviousBillPage";
            this.btnPreviousBillPage.Size = new System.Drawing.Size(107, 22);
            this.btnPreviousBillPage.TabIndex = 3;
            this.btnPreviousBillPage.Text = "Previous";
            this.btnPreviousBillPage.UseVisualStyleBackColor = true;
            this.btnPreviousBillPage.Click += new System.EventHandler(this.btnPreviousBillPage_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(448, 435);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 22);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(569, 435);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(93, 22);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txbPageBill
            // 
            this.txbPageBill.Location = new System.Drawing.Point(314, 438);
            this.txbPageBill.Name = "txbPageBill";
            this.txbPageBill.Size = new System.Drawing.Size(73, 20);
            this.txbPageBill.TabIndex = 4;
            this.txbPageBill.Text = "1";
            this.txbPageBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPageBill.TextChanged += new System.EventHandler(this.txbPageBill_TextChanged);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 469);
            this.Controls.Add(this.txbPageBill);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPreviousBillPage);
            this.Controls.Add(this.btnFristBillPage);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.dtgvBill);
            this.Name = "frmBill";
            this.Text = "frmBill";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DateTimePicker dtgkToDate;
        private System.Windows.Forms.DateTimePicker dtgkFromDate;
        private System.Windows.Forms.Button btnBillwiew;
        private System.Windows.Forms.Button btnFristBillPage;
        private System.Windows.Forms.Button btnPreviousBillPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txbPageBill;
    }
}