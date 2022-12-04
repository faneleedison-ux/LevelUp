using System;
    
    
    
namespace CustomerWebAPI.Models
{
    public class Customers
    {
        public Customers(int CustomerID, string firstname, string lastname, string username, string email, string dob, string age, DateTime dateCreated, DateTime dateModified, bool isDeleted)
        {
            this.CustomerID=CustomerID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.email = email;
            this.dob = dob;
            this.age = age;
            this.dateCreated = dateCreated;
            this.dateModified = dateModified;
            IsDeleted = isDeleted;
        }

        public Customers() 
            { 
        }


        public int CustomerID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public string age { get; set; }
        public DateTime ? dateCreated { get; set; }
        public DateTime ? dateModified { get; set; }
        public bool IsDeleted { get; set; }

    }

 
}
