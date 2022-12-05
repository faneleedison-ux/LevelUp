using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerID");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("UserName");
            dt.Columns.Add("EmailAddress");
            dt.Columns.Add("DateOfBirth");
            dt.Columns.Add("Age");
            dt.Columns.Add("DateCreated");
            dt.Columns.Add("DateEdited");

            dt.Rows.Add(1, "Fanele", "Mbuyazi", "Fah", "fanele@gmail.com", "03-23-1999" , "23" , "12-03-2022" , "12-03-2022");
            dt.Rows.Add(2, "Elaine", "Sodi", "Sodi", "elaine@gmail.com", "11-21-1997", "23", "12-03-2022", "12-03-2022");
            dt.Rows.Add(3, "Siwelile", "Smith", "Siwe", "siwelile@gmail.com", "12-02-1990", "23", "12-03-2022", "12-03-2022");


            return Request.CreateResponse(HttpStatusCode.OK, dt);
        
        
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
