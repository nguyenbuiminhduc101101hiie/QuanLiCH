using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using QuanLiCH.DTO_1;
using QuanLyQuanCafe.DAO;

namespace QuanLiCH.DAO_1
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id );

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }
      
        public List<Bill> GetlistBill()
        {
            List<Bill> listBill = new List<Bill>();
            //string query1 = "UPDATE dbo.Bill SET dateCheckOut = GETDATE(), " + "discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id;

            string query = "SELECT * from dbo.bill";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);

                listBill.Add(bill);

            }

            return listBill;
        }
        public int Deletedulieubill()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Delete FROM dbo.Bill" );

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

        public int Deletedulieubillinfo()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Delete FROM dbo.Billinfo");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }
        public void deleteSLdamua(int id,int count)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Food SET quantity = quantity - " + count +" where id = " +id);
            
        }
        public void PlusSLDamua(int id, int count)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Food SET quantity = quantity + " + count + " where id = " + id);
            
        }
        public void InsertpriceProfit(int idbill, float totalPrice)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_InsertProfit @idbill , @total", new object[] { idbill, totalPrice });
        }
        public void InsertquantityProfit(int quantity, string productname)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Profit SET Quantity = " + quantity + "WHERE ProductName = N'" + productname + "'");
        }
        public void CheckOut(int id, int discount, float totalPrice )
        {
          
            string query = "UPDATE dbo.Bill SET dateCheckOut = GETDATE(), " + "discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id ;
            DataProvider.Instance.ExecuteNonQuery(query);
            
            //string query1 = "SELECT * from dbo.bill";
            //List<Bill> listBill = new List<Bill>();
            //DataTable data = DataProvider.Instance.ExecuteQuery(query1);
            //foreach (DataRow item in data.Rows)
            //{
            //    Bill bill = new Bill(item);

            //    listBill.Add(bill);

            //}
            //GetlistBill();

        }
       
        public void InserBill(int id , float totalPrice)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable , @totalPrice ", new object[] { id, totalPrice });

        }
        public DataTable GetlistProfit()
        {
            return DataProvider.Instance.ExecuteQuery(" SELECT * from dbo.Profit");
        }
        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }
        public DataTable GetListBillByDateAndPage(DateTime checkIn, DateTime checkOut,int pageNum)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @checkIn , @checkOut , @page ", new object[] { checkIn, checkOut,pageNum });
        }
        public int GetNumBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBillByDate @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public int GetMaxIDProfit()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Profit");
            }
            catch
            {
                return 1;
            }
        }


    }

}
