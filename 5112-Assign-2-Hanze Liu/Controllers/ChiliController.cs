using Microsoft.Ajax.Utilities;
using System;
using System.Web.Http;

namespace _5112_Assign_2_Hanze_Liu.Controllers
{
    public class ChiliController : ApiController
    {
        /// <summary>
        /// There are 6 types of chilipepper with different spiciness which meansureed in Scolville Heat Units (SHU).
        /// This solution is created to count the total SHU when adding different types of peppers.
        /// </summary>
        /// <param name="N">means how many numbers of pepper be added in</param>
        /// <param name="peppers">represent what kind of pepper be added in </param>
        /// pepperName is an array which is consisted of every value in peppers and splited by "," .
        /// <returns>T stands for total SHU </returns>
   

        [Route("api/Chili/{N}/{peppers}")]
        [HttpGet]
        public int chili(int N, string peppers)
        {
            string[] pepperName = peppers.Split(',');         
            int T = 0;
            for (int i = 0; i < N; i++)
            {
                switch (pepperName[i])
                {
                    case "Poblano":
                        T += 1500;
                        break;
                    case "Mirasol":
                        T += 6000;
                        break;
                    case "Serrano":
                        T +=15000;
                        break;
                    case "Cayenne":
                        T += 40000;
                        break;
                    case "Thai":
                        T += 75000;
                        break;
                    case "Habanero":
                        T += 125000;
                        break;
                }
               
            }
            return T;
        }
    }
}


