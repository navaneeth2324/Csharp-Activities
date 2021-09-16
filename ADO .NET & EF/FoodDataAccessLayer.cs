using FoodDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDAL
{
    public class FoodDataAccessLayer
    {
        SqlConnection conObj;
        string conStr = ConfigurationManager.ConnectionStrings["Constr"].ConnectionString;
        public FoodDataAccessLayer()
        {
            conObj = new SqlConnection(conStr);
        }

        public List<customerDTO> FetchEmployees()
        {
            List<customerDTO> listcustomers = new List<customerDTO>();


            SqlConnection conObj = new SqlConnection();
            conObj.ConnectionString = conStr;

            SqlCommand queryObj = new SqlCommand();
            queryObj.CommandText = @"SELECT First_Name,Last_Name,[Address]FROM Employee";
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
                        Last_Name = cust["Last_Name"].ToString(),
                        Address = cust["Address"].ToString()
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

        public List<customerDTO> FetchEmployees_adapter()
        {
            try
            {

                List<customerDTO> lst = new List<customerDTO>();
                using (conObj)
                {
                    SqlDataAdapter daObj = new SqlDataAdapter(
                        @"SELECT  [First_Name]
                                 ,[Last_Name]
                                 ,[Address]      
                                 ,[Contact_number]
                                  ,[Email_address]
                              FROM Employee", conObj);

                    daObj.SelectCommand.CommandType = System.Data.CommandType.Text;
                    DataTable dt = new DataTable();
                    daObj.Fill(dt);

                    foreach (DataRow item in dt.Rows)
                    {
                        lst.Add(new customerDTO()
                        {

                            First_Name = item["First_Name"].ToString(),
                            Last_Name = item["Last_Name"].ToString(),
                            Address = item["Address"].ToString(),
                            Contact_number = item["Contact_number"].ToString(),
                            Email_address = item["Email_address"].ToString()

                        });
                    }
                }
                return lst;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UpdateEmployeeWithID(customerDTO e)
        {
            try
            {
                SqlCommand queryobj = new SqlCommand();
                queryobj.CommandText = @"usp_UpdateDetailsofEmployees";
                queryobj.CommandType = System.Data.CommandType.StoredProcedure;
                queryobj.Connection = conObj;
                queryobj.Parameters.AddWithValue("@emp_id", e.Emp_id);
                queryobj.Parameters.AddWithValue("@address", e.Address);
                
                SqlParameter preturn = new SqlParameter();
                preturn.Direction = System.Data.ParameterDirection.ReturnValue;
                preturn.SqlDbType = SqlDbType.Int;
                queryobj.Parameters.Add(preturn);
                conObj.Open();
                queryobj.ExecuteNonQuery();

                return Convert.ToInt32(preturn.Value);
            }

            catch (Exception ex) { throw ex; }
            finally { conObj.Close(); }
        }

        public int InserttoEmployee(customerDTO d)
        {
            try
            {
                SqlCommand queryobj = new SqlCommand();
                queryobj.CommandText = @"usp_InsertEmployee";
                queryobj.CommandType = System.Data.CommandType.StoredProcedure;
                queryobj.Connection = conObj;
                queryobj.Parameters.AddWithValue("@emp_id", d.Emp_id);
                queryobj.Parameters.AddWithValue("@first_name", d.First_Name);
                queryobj.Parameters.AddWithValue("@last_name",d.Last_Name );
                queryobj.Parameters.AddWithValue("@age", d.Age);
                queryobj.Parameters.AddWithValue("@address", d.Address);
                queryobj.Parameters.AddWithValue("@contact_number", d.Contact_number);
                queryobj.Parameters.AddWithValue("@email", d.Email_address);
                SqlParameter preturn = new SqlParameter();
                preturn.Direction = System.Data.ParameterDirection.ReturnValue;
                preturn.SqlDbType = SqlDbType.Int;
                queryobj.Parameters.Add(preturn);
                conObj.Open();
                queryobj.ExecuteNonQuery();

                return Convert.ToInt32(preturn.Value);
            }

            catch (Exception e) { throw e; }
            finally { conObj.Close(); }
        }
    }
}
