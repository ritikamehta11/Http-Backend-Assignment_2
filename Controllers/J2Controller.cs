using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{

    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        /// <summary>
        /// Counts the number of ways to get 10
        /// </summary>
        /// <param name="id">food choice</param>
        /// <returns>number of ways to get sum as 10</returns>
        /// GET api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10.
        /// GET api/J2/DiceGame/12/4 -> There are 4 ways to get the sum 10
        /// GET api/J2/DiceGame/3/3 -> There are 0 ways to get the sum 10
        public string DiceGame(int m, int n)
        {
           int count = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }

                }
            }
            if(count==1)
            {
                return $"There is {count} way to get 10.";  
                    }
            else if (count == 0 || count>1)
            {
                return $"There are {count} ways to get 10.";
            }
            return "";
        }
 
        
    }
}
