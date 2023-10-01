﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumbaMobileApp.Models
{
    public class Concession
    {
        public int ConcessionID { get; set; }
        public int ConcessionType { get; set; }
        public int NumLeft { get; set; }
        public int UserID { get; set; }
        public DateTime DatePaid { get; set; }
        public string Status { get; set; }
        public Concession(int concessionID, int concessionType, int numLeft, int userID, DateTime datePaid, string status)
        {
            this.ConcessionID = concessionID;
            this.ConcessionType = concessionType;
            this.NumLeft = numLeft;
            this.UserID = userID;
            this.DatePaid = datePaid;
            this.Status = status;
        }
    }
}
