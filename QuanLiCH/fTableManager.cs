using System;
using System.Collections.Generic;
using System.ComponentModel;
 using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using QuanLiCH.DAO_1;
using QuanLiCH.DTO_1;
using static QuanLiCH.fAccoutProfile1;

namespace QuanLiCH
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            timer1.Start();
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwithTable);
            
        }

        #region Methor
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type==1;
            thôngTinTàiKhoảnlStripMenuItem.Text +=  ":  Xin Chào  " + LoginAccount.DisplayName + " ";

        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetlistCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";

        }
        
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood =FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {   
            flpTable.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.LoadTableList(); 
            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight }; 
                btn.Text = item.Name + Environment.NewLine+"price: "+ item.Price + Environment.NewLine+"SL còn: " +item.Quantity; 

                btn.Click += Btn_Click;
                btn.Tag = item;

                flpTable.Controls.Add(btn);
            }    
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLiCH.DTO_1.Menu> listBillInfo = MenuDAO.Instance.GetlistMenuByTable(id);

            float totalPrice = 0;

            foreach (QuanLiCH.DTO_1.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice+=item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN"); // tạo culture ở vn

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);

        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID; // Tạo id Table
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            fLogin f = new fLogin();
            f.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccoutProfile1 f=new fAccoutProfile1(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        private void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnlStripMenuItem.Text=  "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAdmin f = new frmAdmin(loginAccount);
            Admin.frmFood  food=new Admin.frmFood();
            food.InsertFood += f_InsertFood;
            food.DeleteFood += f_DeleteFood;
            food.UpdateFood += f_UpdateFood;
            Admin.frmCategory category=new Admin.frmCategory();
            category.InsertCategory += f_InsertCategory;
            category.UpdateCategory += f_UpdateCategory;
            category.DeleteCategory += f_DeleteCategory;

            f.ShowDialog();
        }

        private void f_DeleteCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);

            LoadTable();
        }

        private void f_UpdateCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void f_InsertCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if(lsvBill.Tag != null)
            ShowBill((lsvBill.Tag as Table).ID);

            LoadTable();
        }

        private void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void f_InsertFood(object sender, EventArgs e)
        {
             
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb= sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected= cb.SelectedItem as Category;

            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
           
            if (table == null)
            {
                MessageBox.Show("Hãy chọn gì đó trước khi thêm số lượng");
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCout.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InserBill(table.ID);
                BillInfoDAO.Instance.InserBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InserBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);
            LoadTable();
        }

      

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;

            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);

                    LoadTable();
                }
            }
        }
        //private void btnSwithTable_Click(object sender, EventArgs e)
        //{
        //    int id1 = (lsvBill.Tag as Table).ID;

        //    int id2 = (cbSwithTable.SelectedItem as Table).ID;
        //    if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwithTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
        //    {
        //        TableDAO.Instance.SwitchTable(id1, id2);

        //        LoadTable();
        //    }
        //}

        #endregion

        private void btnRename_Click(object sender, EventArgs e)
        {
            fAccoutProfile1 f = new fAccoutProfile1(loginAccount);
/*            this.Hide();*/
            f.ShowDialog();
           

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            fLogin f = new fLogin();
            f.ShowDialog();

        }
    }
}
