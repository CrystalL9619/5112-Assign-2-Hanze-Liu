using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5112_Assign_2_Hanze_Liu.Controllers
{
    public class DelivedroidController : ApiController
    {
        /// <summary>
        ///  a robot droid has to deliver packages while avoiding obstacles
        /// </summary>
        /// <param name="P">P means how many packages are successfully delived</param>
        /// <param name="C">C means how many packages are failed to delived</param>
        /// sucessfulPoint represents that the robot droid earn  every package delived sucessfully 
        /// losePoint represents that the robot droid lose 10 points for every omission.
        /// Earn a bonus 500 points if the number of succeful delived packages are greater than the number of failed 
        /// <returns> F means the final points that the robot droid earns</returns>
    
                [HttpGet]
        [Route("api/{Delivedroid}/{GetF}/{P}/{C}")]
          public int GetF (int P,int C) {
            int sucessfulPoint = P * 50;
            int losePoint = C * 10;
            int F = sucessfulPoint - losePoint;
            
            if (P > C) { F += 500; }
            return F; 
        }
    }
}
