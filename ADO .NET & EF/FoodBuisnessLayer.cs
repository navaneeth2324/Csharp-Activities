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
        public List<customerDTO> GetAllcustomers()
        {
            FoodDataAccessLayer dalObj = new FoodDataAccessLayer();
            return dalObj.Fetchcustomers();
        }
    }
}
