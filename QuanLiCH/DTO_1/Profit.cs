using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLiCH.DTO_1
{
    public class Profit
    {


        public Profit(int id, int idbill, string productname, int quantity, DateTime? datepurchase, float totalprice)
        {
            this.ID = id;
            this.IDBill = idbill;
            this.Productname = productname;
            this.Quantity = quantity;
            this.DatePurchase = datepurchase;
            this.TotalPrice = totalprice;
        }
        public Profit(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDBill = (int)row["idbill"];
            this.Quantity = (int)row["quantity"];
            this.Productname = row["productname"].ToString();
            this.DatePurchase = (DateTime?)row["datepurchase"];
            this.TotalPrice = (float)Convert.ToDouble(row["totalprice"].ToString());
        }
        private int iD;
        private int iDBill;

        private string productname;

        private int quantity;

        private DateTime? datepurchase;

        private float totalprice;


        public int ID { get => iD; set => iD = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public string Productname { get => productname; set => productname = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime? DatePurchase
        {
            get => datepurchase;
            set => datepurchase = value;
        }
        public float TotalPrice { get => totalprice; set => totalprice = value; }

    }
}
