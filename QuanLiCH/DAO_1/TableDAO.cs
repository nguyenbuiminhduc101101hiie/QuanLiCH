using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLiCH.DTO_1;
using QuanLyQuanCafe.DAO;

namespace QuanLiCH.DAO_1
{
    public class TableDAO
    {
        private static TableDAO instance; // Tạo singleton

        public static TableDAO Instance 
        { 
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
          private  set { TableDAO.instance = value; }
        }
        public static int TableWidth = 95;  //      Tạo chiều cao button
        public static int TableHeight = 95; //        Tạo chiều rộng Button
        private  TableDAO() { }

        //public void SwitchTable(int id1, int id2)
        //{
        //    DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        //}
        
        public List<Food>  LoadTableList() // Tạo đanh sách bàn ăn
        {
            List<Food> tableList = new List<Food>();
            string query1 = "Select * From Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query1);

            foreach (DataRow item in data.Rows)
            {
                Food table = new Food(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public List<Food> GetListTabble()
        {
            List<Food> list = new List<Food>();

            string query = "Select * From Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food table = new Food(item);
                list.Add(table);
            }

            return list;
        }
        //public Table GetTableByID(int id)
        //{
        //    Table category = null;

        //    List<Table> list = new List<Table>();

        //    string query = "select * from TableFood where id = " + id;
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        category = new Table(item);
        //        list.Add(category);

        //    }
        //    return category;
        //}
    }
    
}
