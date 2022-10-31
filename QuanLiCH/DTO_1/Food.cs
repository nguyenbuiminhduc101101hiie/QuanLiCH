using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
   public class Food
    {
         private int iD;

        private string name;

        private int categoryID;

        private float price;

        private int quantity;

        public Food(int id,string name, int categoryid,float price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryid;
            this.Price = price;
            this.Quantity = quantity;
        }
        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Quantity = (int)row["quantity"];
        }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
