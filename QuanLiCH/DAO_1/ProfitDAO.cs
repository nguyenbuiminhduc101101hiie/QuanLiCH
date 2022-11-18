using Microsoft.SqlServer.Management.Sdk.Sfc;
using QuanLiCH.DTO_1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DAO;
using DataProvider = QuanLyQuanCafe.DAO.DataProvider;
using Microsoft.SqlServer.Management.Smo;
using System.Windows;

namespace QuanLiCH.DAO_1
{
    public class ProfitDAO
    {
        private static ProfitDAO instance; // Tạo singleton

        public static ProfitDAO Instance
        {
            get { if (instance == null) instance = new ProfitDAO(); return ProfitDAO.instance; }
            private set { ProfitDAO.instance = value; }
        }

        private ProfitDAO() { }

        public List<Profit> Loadlistprofit() 
        { 
            List<Profit> ProfitList = new List<Profit>();
            string query = "Select * From Profit";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Profit table = new Profit(item);
                ProfitList.Add(table);
            }



            return ProfitList;
        }
        //public string Loadtotalprofitbydate(DateTime checkIn, DateTime checkOut)
        //{
        //    //float totalprofit = 0;
        //    //DataTable data = ProfitDAO.instance.GetlistProfit(checkIn, checkOut);
            
        //    //foreach (DataTable item in data.Rows) 
        //    //{
        //    //    totalprofit += item.  ;
        //    //}
        //    //return totalprofit.ToString();
        //}
        public string Loadtotalprofit()
        {
            float totalprofit = 0;
            List<Profit> profitlist = ProfitDAO.Instance.Loadlistprofit();
            foreach (Profit item in profitlist)
            {
                totalprofit += item.TotalPrice;
            }
            return totalprofit.ToString();
        }
        public DataTable GetlistProfit(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListProfit @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }

    }

}
