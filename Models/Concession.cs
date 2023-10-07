using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZumbaMobileApp.ViewModel;

namespace ZumbaMobileApp.Models
{
    public partial class Concession : ObservableObject
    {
        public int ConcessionID { get; set; }
        public string ConcessionType { get; set; }
        public int TotalNum { get; set; }
        public int NumLeft { get; set; }
        public int UserID { get; set; }
        public DateTime? DatePaid { get; set; }
        public string Status { get; set; }

        // Basic concession constructor
        public Concession(int concessionID, string concessionType, int totalNum, int numLeft, int userID, string status)
        {
            this.ConcessionID = concessionID;
            this.ConcessionType = concessionType;
            this.TotalNum = totalNum;
            this.NumLeft = numLeft;
            this.UserID = userID;
            this.DatePaid = null;
            this.Status = status;
        }

        // Second constructor
        public Concession(int concessionID, string concessionType, int totalNum, int numLeft, int userID, DateTime datePaid, string status)
        {
            this.ConcessionID = concessionID;
            this.ConcessionType = concessionType;
            this.TotalNum = totalNum;
            this.NumLeft = numLeft;
            this.UserID = userID;
            this.DatePaid = datePaid;
            this.Status = status;
        }
    }
}
