using FoodDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDAL
{
    public class FoodDataAccessLayer
    {
        public List<customerDTO> Fetchcustomers()
        {
            List<customerDTO> listcustomers = new List<customerDTO>();

            string conStr = @"Server=(localdb)\MSSQLLocalDB;Database=FoodOrderingSystemDatabase;Trusted_Connection=True;";
            SqlConnection conObj = new SqlConnection();
            conObj.ConnectionString = conStr;

            SqlCommand queryObj = new SqlCommand();
            queryObj.CommandText = @"SELECT First_Name,Last_Name FROM Customers";
            queryObj.CommandType = System.Data.CommandType.Text;
            queryObj.Connection = conObj;

            try
            {
                conObj.Open();
                SqlDataReader cust = queryObj.ExecuteReader();
                while (cust.Read())
                {
                    listcustomers.Add(new customerDTO()
                    {
                        First_Name = cust["First_Name"].ToString(),
                        Last_Name = cust["Last_Name"].ToString()
                    }
                    );
                }
                return listcustomers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
