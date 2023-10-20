using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;

namespace _5112_Assign_2_Hanze_Liu.Controllers
{
    public class EventController : ApiController
    {
        /// <summary>
        /// This one doesn't work .
        /// </summary>
        /// There is a 5-days event.
        /// <param name="N">N means the number of people would like to attend the event </param>
        /// <param name="attendance">attendance means whether the each person will be able to attend these 5-days event base on every day.
        /// </param>
        /// <param name="Y"> Y means "Yes", this person will attend this day's event</param>
        /// <param name="."> . means "No", this person will not  attend this day's event</param>
        /// attend is an array which is consisted of every value in attendance and splited by "," .
        /// d1 is represent Day1,d2 is represent Day2,etc.
        /// what I'm thinking is:
        /// For instance,there are 3 people. 
        /// person1's attendance is YY.Y.,person2's attendance is ...Y.,person3's attendance is .YYY.
        /// string attend[]={YY.Y.,...Y.,.YYY.}
        /// attend[0]=YY.Y.  which means person1 will attend Day1, Day2 and Day4 and will absent Day3 and Day5.
        /// then the first for element is created to count how many people will atten each days 
        /// the maxValue is for checking which day has the largest number of attendee in the day array.
        /// the maxIndex is which index the maxValue located
        /// And because of index of array start from 0,]
        /// so if , for example, day 2 has the most attendee, the index is 1, then the day should be maxIndex+1;
        /// <returns name="day">day </returns>
        [Route("api/event/{N}/{attendance}")]
        [HttpGet]
        public int[] day(int N, string attendance)
        {
            string[] attend = attendance.Split(',');

            int d1 = 0;
            int d2 = 0;
            int d3 = 0;
            int d4 = 0;
            int d5 = 0;
          
         
            for (int i = 0; i < N; i++)
            {
                if (attend[0].ToCharArray()[i] == 'Y')
                {
                    d1 += 1;
                }
                else if (attend[0].ToCharArray()[i] == '.')
                {
                    d1 += 0;
                }

                if (attend[1].ToCharArray()[i] == 'Y')
                {
                    d2 += 1;
                }
                else if (attend[1].ToCharArray()[i] == '.')
                {
                    d2 += 0;
                }
                if (attend[2].ToCharArray()[i] == 'Y')
                {
                    d3 += 1;
                }
                else if (attend[2].ToCharArray()[i] == '.')
                {
                    d3 += 0;
                }
                if (attend[3].ToCharArray()[i] == 'Y')
                {
                    d4 += 1;
                }
                else if (attend[3].ToCharArray()[i] == '.')
                {
                    d4 += 0;
                }

                if (attend[4].ToCharArray()[i] == 'Y')
                {
                    d5 += 1;
                }
                else if (attend[4].ToCharArray()[i] == '.')
                {
                    d5 += 0;
                }
            }
            int[] days = { d1, d2, d3, d4, d5 };
            int maxValue = days.Max();
            int maxIndex = days.ToList().IndexOf(maxValue);
            int[] day = { maxIndex+1 };
            return day;
        }
    }
}

            
