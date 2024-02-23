using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J3/Instructions/{num}")]
        
        public string Instructions(int num)
        {
            ///<summary>
            ///This is a J3 problem. The initail problem was:
            ///there are atleast 2 inputs(all inputs 5 digits and first two digits of first instruction are not 00),
            ///and the last input would be 99999 that tells that it was the last instruction)
            ///The first two digits represent the direction to turn:
            ///If their sum is odd, then the direction to turn is left.
            ///If their sum is even and not zero, then the direction to turn is right.
            ///If their sum is zero, then the direction to turn is the same as the previous instruction.
            ///The remaining three digits represent the number of steps to take which will always be atleast 100.
            ///Our job is to decode the instructions so the assistant can use them to find the secret formula.
            /// 
            /// Now for this problem, i have simplied it for only one input at a time.
            /// </summary>
            /// <param name="num">a code number taht we have to decode</param>
            /// <returns>The direction and number of steps</returns>
            /// <example>
            /// GET api/J3/Instructions/57234 -> right 234
            /// GET api/J3/Instructions/34100 -> left 100
            /// </example>
            int dirNum = num / 1000;
            int steps = num % 1000;
            string direction = "";

            int dirSum = (dirNum/10) + (dirNum%10);
            if (dirSum % 2 == 0)
            {
                direction = "right";
            }
            else direction = "left";

            return $"{direction} {steps} ";
        }

    }
}
