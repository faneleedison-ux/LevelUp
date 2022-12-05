using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Customers
    {
        public long CustomerID {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public string Username
        {
            get; set;
        }

        public string EmailAddress
        {
            get; set;
        }

        public DateTime DOB
        {
            get; set;
        }

        public int  Age
        {
            get; set;
        }

        public DateTime ? DateCreated
        {
            get; set;
        }

        public DateTime ? DateEdited
        {
            get; set;
        }
        public Boolean IsDeleted
        {
            get; set;
        }

    }
}