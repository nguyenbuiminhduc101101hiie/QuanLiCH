namespace QuanLiCH.Admin
{
    partial class frmFood
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
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnFoodPrice = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.lbFoodPrice = new System.Windows.Forms.Label();
            this.pnFoodCategory = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.lbFoodCategory = new System.Windows.Forms.Label();
            this.pnFoodName = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.pnFoodID = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.lbFoodId = new System.Windows.Forms.Label();
            this.pnSreach = new System.Windows.Forms.Panel();
            this.txbSreachFoodName = new System.Windows.Forms.TextBox();
            this.btnSreachFood = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnFoodPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.pnFoodCategory.SuspendLayout();
            this.pnFoodName.SuspendLayout();
            this.pnFoodID.SuspendLayout();
            this.pnSreach.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(18, 198);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.Size = new System.Drawing.Size(1074, 210);
            this.dtgvFood.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnFoodCategory);
            this.panel4.Controls.Add(this.pnFoodID);
            this.panel4.Location = new System.Drawing.Point(13, 48);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 142);
            this.panel4.TabIndex = 4;
            // 
            // pnFoodPrice
            // 
            this.pnFoodPrice.Controls.Add(this.nmFoodPrice);
            this.pnFoodPrice.Controls.Add(this.lbFoodPrice);
            this.pnFoodPrice.Location = new System.Drawing.Point(513, 126);
            this.pnFoodPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnFoodPrice.Name = "pnFoodPrice";
            this.pnFoodPrice.Size = new System.Drawing.Size(444, 50);
            this.pnFoodPrice.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(136, 4);
            this.nmFoodPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(275, 22);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // lbFoodPrice
            // 
            this.lbFoodPrice.AutoSize = true;
            this.lbFoodPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodPrice.Location = new System.Drawing.Point(4, 5);
            this.lbFoodPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFoodPrice.Name = "lbFoodPrice";
            this.lbFoodPrice.Size = new System.Drawing.Size(49, 24);
            this.lbFoodPrice.TabIndex = 0;
            this.lbFoodPrice.Text = "Giá:";
            // 
            // pnFoodCategory
            // 
            this.pnFoodCategory.Controls.Add(this.cbFoodCategory);
            this.pnFoodCategory.Controls.Add(this.lbFoodCategory);
            this.pnFoodCategory.Location = new System.Drawing.Point(4, 69);
            this.pnFoodCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnFoodCategory.Name = "pnFoodCategory";
            this.pnFoodCategory.Size = new System.Drawing.Size(426, 59);
            this.pnFoodCategory.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(136, 22);
            this.cbFoodCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(271, 24);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // lbFoodCategory
            // 
            this.lbFoodCategory.AutoSize = true;
            this.lbFoodCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodCategory.Location = new System.Drawing.Point(5, 21);
            this.lbFoodCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFoodCategory.Name = "lbFoodCategory";
            this.lbFoodCategory.Size = new System.Drawing.Size(112, 24);
            this.lbFoodCategory.TabIndex = 0;
            this.lbFoodCategory.Text = "Danh Mục:";
            // 
            // pnFoodName
            // 
            this.pnFoodName.Controls.Add(this.txbFoodName);
            this.pnFoodName.Controls.Add(this.lbFoodName);
            this.pnFoodName.Location = new System.Drawing.Point(513, 52);
            this.pnFoodName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnFoodName.Name = "pnFoodName";
            this.pnFoodName.Size = new System.Drawing.Size(444, 54);
            this.pnFoodName.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(137, 23);
            this.txbFoodName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(272, 22);
            this.txbFoodName.TabIndex = 1;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodName.Location = new System.Drawing.Point(4, 22);
            this.lbFoodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(100, 24);
            this.lbFoodName.TabIndex = 0;
            this.lbFoodName.Text = "Tên Món:";
            // 
            // pnFoodID
            // 
            this.pnFoodID.Controls.Add(this.txbFoodID);
            this.pnFoodID.Controls.Add(this.lbFoodId);
            this.pnFoodID.Location = new System.Drawing.Point(5, 9);
            this.pnFoodID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnFoodID.Name = "pnFoodID";
            this.pnFoodID.Size = new System.Drawing.Size(429, 52);
            this.pnFoodID.TabIndex = 1;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(136, 23);
            this.txbFoodID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(260, 22);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // lbFoodId
            // 
            this.lbFoodId.AutoSize = true;
            this.lbFoodId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodId.Location = new System.Drawing.Point(28, 25);
            this.lbFoodId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFoodId.Name = "lbFoodId";
            this.lbFoodId.Size = new System.Drawing.Size(36, 24);
            this.lbFoodId.TabIndex = 0;
            this.lbFoodId.Text = "ID:";
            // 
            // pnSreach
            // 
            this.pnSreach.Controls.Add(this.txbSreachFoodName);
            this.pnSreach.Controls.Add(this.btnSreachFood);
            this.pnSreach.Location = new System.Drawing.Point(9, 436);
            this.pnSreach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnSreach.Name = "pnSreach";
            this.pnSreach.Size = new System.Drawing.Size(463, 65);
            this.pnSreach.TabIndex = 5;
            // 
            // txbSreachFoodName
            // 
            this.txbSreachFoodName.Location = new System.Drawing.Point(36, 21);
            this.txbSreachFoodName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSreachFoodName.Name = "txbSreachFoodName";
            this.txbSreachFoodName.Size = new System.Drawing.Size(248, 22);
            this.txbSreachFoodName.TabIndex = 2;
            // 
            // btnSreachFood
            // 
            this.btnSreachFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSreachFood.Location = new System.Drawing.Point(317, 1);
            this.btnSreachFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSreachFood.Name = "btnSreachFood";
            this.btnSreachFood.Size = new System.Drawing.Size(133, 66);
            this.btnSreachFood.TabIndex = 1;
            this.btnSreachFood.Text = "Tìm";
            this.btnSreachFood.UseVisualStyleBackColor = false;
            this.btnSreachFood.Click += new System.EventHandler(this.btnSreachFood_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(959, 462);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFood.Location = new System.Drawing.Point(740, 462);
            this.btnUpdateFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(115, 42);
            this.btnUpdateFood.TabIndex = 1;
            this.btnUpdateFood.Text = "Update";
            this.btnUpdateFood.UseVisualStyleBackColor = false;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(557, 462);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(101, 42);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Add";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(460, 9);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(122, 35);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "Thức Ăn";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 511);
            this.Controls.Add(this.pnFoodPrice);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateFood);
            this.Controls.Add(this.pnFoodName);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pnSreach);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dtgvFood);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFood";
            this.Text = "frmFood";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.pnFoodPrice.ResumeLayout(false);
            this.pnFoodPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.pnFoodCategory.ResumeLayout(false);
            this.pnFoodCategory.PerformLayout();
            this.pnFoodName.ResumeLayout(false);
            this.pnFoodName.PerformLayout();
            this.pnFoodID.ResumeLayout(false);
            this.pnFoodID.PerformLayout();
            this.pnSreach.ResumeLayout(false);
            this.pnSreach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnFoodPrice;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label lbFoodPrice;
        private System.Windows.Forms.Panel pnFoodCategory;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label lbFoodCategory;
        private System.Windows.Forms.Panel pnFoodName;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Panel pnFoodID;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label lbFoodId;
        private System.Windows.Forms.Panel pnSreach;
        private System.Windows.Forms.TextBox txbSreachFoodName;
        private System.Windows.Forms.Button btnSreachFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Label lb1;
    }
}