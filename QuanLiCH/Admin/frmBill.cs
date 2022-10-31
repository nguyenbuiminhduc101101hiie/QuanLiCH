using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCH.DAO_1;

namespace QuanLiCH.Admin
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadListBillByDate(dtgkFromDate.Value, dtgkToDate.Value);
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtgkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtgkToDate.Value = dtgkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
        }


        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtgkFromDate.Value, dtgkToDate.Value);
        }

        private void btnFristBillPage_Click(object sender, EventArgs e)
        {
            txbPageBill.Text = "1";
        }

        private void btnPreviousBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageBill.Text);
            if (page > 1) page--;
            txbPageBill.Text = page.ToString();
        }

        private void txbPageBill_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDateAndPage(dtgkFromDate.Value, dtgkToDate.Value, Convert.ToInt32(txbPageBill.Text));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageBill.Text);
            int sumRecord = BillDAO.Instance.GetNumBillByDate(dtgkFromDate.Value, dtgkToDate.Value);
            int LastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
            {
                LastPage++;
            }
            if (page < LastPage) page++;
            txbPageBill.Text = page.ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            {
                int sumRecord = BillDAO.Instance.GetNumBillByDate(dtgkFromDate.Value, dtgkToDate.Value);
                int LastPage = sumRecord / 10;
                if (sumRecord % 10 != 0)
                {
                    LastPage++;
                }
                txbPageBill.Text = LastPage.ToString();
            }
        }
    }
}
