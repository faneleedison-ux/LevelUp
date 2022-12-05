using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication.Controllers
{
    public class CustomersController : ApiController
    {
        
        
        // endpont to get all customers in datatable

        public HttpResponseMessage Get() {

            DataTable table = new DataTable();

            string query = @"
                    SELECT customerid, firstname , 
                    lastname, username, emailaddress, 
                    dateofbirth,age , datecreated, dateedited, isdeleted FROM dbo.Customers; 

                    ";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomersDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var adapter = new SqlDataAdapter(cmd))

            {
                cmd.CommandType = CommandType.Text;
                adapter.Fill(table);
            }


            return Request.CreateResponse(HttpStatusCode.OK , table);
        }
        







        // endpont to create a new customer
        public string Post (Customers customer)
        {
            try
            {
                DataTable table = new DataTable();

                string query = @"
                insert into dbo.Customers values ('"+ customer.FirstName + customer.LastName + 
                        customer.Username + customer.EmailAddress +
                        customer.DOB + customer.DateCreated + customer.DateEdited + customer.IsDeleted + @"') 
                            ";


                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomersDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var adapter = new SqlDataAdapter(cmd))

                {
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(table);
                }

                return "New Customer Added Successfully!";
            }
            catch (Exception)
            {

                return "New Customer Could Not Be Added, Please Try Again";
            }
        }


        // endpont to update an existing customer record

        public string Put(Customers customer)
        {
            try
            {
                DataTable table = new DataTable();

                string query = @"
                update  dbo.Customers set
                FirstName= '" + customer.FirstName + @"'
                ,LastName= '" + customer.LastName + @"'
                ,Username= '" + customer.Username + @"'
                ,EmailAddress= '" + customer.EmailAddress + @"'
                ,DateOfBirth= '" + customer.DOB + @"'
                ,Age= '" + customer.Age + @"'
                ,DateCreated= '" + customer.DateCreated + @"'
                ,DatedEdited= '" + customer.DateEdited + @"'
                ,Deleted= '" + customer.IsDeleted + @"'
                where CustomerID = "+ customer.CustomerID + @"'
                
                            ";


                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomersDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var adapter = new SqlDataAdapter(cmd))

                {
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(table);
                }

                return "Customer Updated Successfully!";
            }
            catch (Exception)
            {

                return "Customer Could Not Be Updated, Please Try Again";
            }
        }

        // endpont to delete an existing customer record

        public string Delete (int Id)
        {
            try
            {
                DataTable table = new DataTable();

                string query = @"
                dalete from dbo.Customers where CustomerID = "+ Id;


                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomersDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var adapter = new SqlDataAdapter(cmd))

                {
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(table);
                }

                return "Customer Deleted Successfully!";
            }
            catch (Exception)
            {

                return "Customer Could Not Be Deleted, Please Try Again";
            }
        }


        // end point to get single customer details
        public HttpResponseMessage GetCustomer(int Id)
        {
            try
            {
                DataTable table = new DataTable();
              

                string query = @"
                select * from dbo.Customers where CustomerID = " + Id;


                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomersDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var adapter = new SqlDataAdapter(cmd))

                {
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(table);
                }

                return Request.CreateResponse(HttpStatusCode.OK, table);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
