using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumbaMobileApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Passkey { get; set; }
        public string Residence { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime? DateLeft { get; set; }

        
        public User(int userID, string firstName, string lastName, string email, string passkey, string residence, string phoneNumber, int age, string gender, DateTime dateJoined)
        {
            this.UserID = userID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Passkey = passkey;
            this.Residence = residence;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
            this.Gender = gender;
            this.DateJoined = dateJoined;
            this.DateLeft = null;
        }
    }
}
