using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public int Menu(int burger, int drink, int side, int dessert)
        {
            /// <summary>
            /// Counts the number of calories
            /// </summary>
            /// <summary>
            /// 3 burger choices: 
            /// 1 - Cheeseburger (461 Calories)
            /// 2 - Fish Burger (431 Calories)
            /// 3 - Veggie Burger (420 Calories)
            /// 4 - no burger
            /// </summary>
            /// <summary>
            /// Here are the three drink choices:
            /// 1 - Soft Drink (130 Calories)
            /// 2 - Orange Juice (160 Calories)
            /// 3 - Milk (118 Calories)
            /// 4 - no drink
            /// </summary>
            /// <summary>
            /// Here are the 3 side order choices:
            /// 1 - Fries (100 Calories)
            /// 2 - Baked Potato (57 Calories)
            /// 3 - Chef Salad (70 Calories)
            /// 4 - no side order
            /// </summary>
            /// /// <summary>
            /// Here are the three dessert choices:
            /// 1 - Apple Pie (167 Calories)
            /// 2 - Sundae (266 Calories)
            /// 3 - Fruit Cup (75 Calories)
            /// 4 - No Dessert
            /// </summary>
            /// <param name="id">food choice</param>
            /// <returns>Total calories of the chosen food</returns>
            /// GET api/J1/Menu/4/4/4/4 -> 0
            /// GET api/J1/Menu/1/2/3/4 -> 691


            int[] burgerCal = { 461, 431, 420, 0 };
            int[] drinkCal = { 130, 160, 118, 0 };
            int[] sideCal = { 100, 57, 70, 0 };
            int[] dessertCal = { 167, 266, 75, 0 };

            int CalCount = burgerCal[burger - 1] + drinkCal[drink - 1] + sideCal[side - 1] + dessertCal[dessert - 1];
            return CalCount;
        }

    }

}

