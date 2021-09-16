using FoodDAL;
using FoodDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBL
{
    public class FoodBusinessLayer
    {
        public List<customerDTO> GetAllEmployees()
        {
            FoodDataAccessLayer dalObj = new FoodDataAccessLayer();
            return dalObj.FetchEmployees();
        }
        public List<customerDTO> FetchEmployeeDetails()
        {
            FoodDataAccessLayer dalObj = new FoodDataAccessLayer();
            return dalObj.FetchEmployees_adapter();

        }

        public int UpdateEmployee(customerDTO e)
        {
            FoodDataAccessLayer dalObj = new FoodDataAccessLayer();
            return dalObj.UpdateEmployeeWithID(e);
        }

        public int InserttIntoEmployeeDB(customerDTO u)
        {
            FoodDataAccessLayer dalObj = new FoodDataAccessLayer();
            return dalObj.InserttoEmployee(u);
        }
    }
}
