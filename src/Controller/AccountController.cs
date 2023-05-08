using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_Agilfornec_Model;
using System.Data.SqlClient;



namespace Login_Agilfornec_Controller
{
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader dr;
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View;
        }
        void connectionString()
        {
            connectionString.connectionString = "data source=root; database=agilfornecbd; integrated security=SSPI;";
        }
        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from usuario where Username='" + acc.Name + "'and password='" + acc.Password + "' and Filial_trabalhada='" + acc.Password + "' ";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Create");
            }
            else
            {
                con.Close();
                return View("Error");
            }

        }
    }
}