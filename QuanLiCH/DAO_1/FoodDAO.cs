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
   public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where idCategory = " + id ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetFoodByID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "Select * from Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();

            string query = string.Format("SELECT * FROM dbo.Food WHERE name LIKE N'%' +(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public DataTable LoadRenameFood(int id,int idCategory,string name,float price, int quantity, string unit)
        {
            return DataProvider.Instance.ExecuteQuery("exec CREATE PROC USP_LoadRenameFood@id , @idCategory , @name , @price ,@quantity ,@unit ", new object[] { id,idCategory,name,price,quantity,unit });
        }
        public bool InsertFood(string name,int id,float price,int quantity, string unit)
        {
            string query = string.Format("INSERT dbo.Food (name, idCategory, price , quantity ,unit )VALUES  ( N'{0}', {1}, {2},{3},N'{4}')", name, id, price,quantity,unit);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateFood(int idFood, string name, int id, float price, int quantity, string unit)
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = {1}, price = {2} ,quantity ={3} ,unit =N'{4}' WHERE id = {5}", name, id, price,quantity,unit, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("Delete Food where id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public void InsertProductProfit(int idFood, float totalPrice)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Profit SET ProductName = N'" + GetNameFoodByID(idFood) + "' WHERE TotalPrice = " + totalPrice);
        }
        public string GetNameFoodByID(int idFood)
        {
            List<string> list = new List<string>();

            string query = ("Select * from Food where id = " + idFood);
            string result = "Space";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food.Name);
                 result = food.Name;
            }
            return result;
        }
    }
}
