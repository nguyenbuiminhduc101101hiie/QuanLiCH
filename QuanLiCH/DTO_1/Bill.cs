using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
  public class Bill
    {
        public Bill(int id,DateTime? dateCheckIn,DateTime? dateCheckOut,int status,int discount)
        {
            this.ID = id;
            this.dateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
            
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.Status = (int)row["status"];

            if (row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];

        }
        private int status;

        private DateTime? dateCheckIn; // kiểu dữ liệu k cho null thêm ? để null

        private DateTime? dateCheckOut;

        private int discount;

        private int iD;

        public int ID 
        {
            get => iD;
            set => iD = value; 
        }
        public DateTime? DateCheckIn 
        { 
            get => dateCheckIn; 
            set => dateCheckIn = value;
        }
        public DateTime? DateCheckOut 
        { 
            get => dateCheckOut; 
            set => dateCheckOut = value; 
        }
        public int Status 
        {
            get => status; 
            set => status = value; 
        }
        public int Discount { get => discount; set => discount = value; }
    }
}
