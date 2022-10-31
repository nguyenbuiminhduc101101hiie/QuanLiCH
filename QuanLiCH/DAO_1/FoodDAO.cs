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
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "Select f.id, f.name, fc.name, f.price from Food f inner join FoodCategory fc on f.idCategory = fc.id";

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
        public DataTable LoadRenameFood(int id,int idCategory,string name,float price, int quantity)
        {
            return DataProvider.Instance.ExecuteQuery("exec CREATE PROC USP_LoadRenameFood@id , @idCategory , @name , @price ,@quantity ", new object[] { id,idCategory,name,price,quantity });
        }
        public bool InsertFood(string name,int id,float price,int quantity)
        {
            string query = string.Format("INSERT dbo.Food ( name, idCategory, price , quantity )VALUES  ( N'{0}', {1}, {2},{3})", name, id, price,quantity);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateFood(int idFood, string name, int id, float price, int quantity)
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = {1}, price = {2} ,quantity ={3} WHERE id = {4}", name, id, price,quantity, idFood);
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

       
    }

}
