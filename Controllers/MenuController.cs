using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Loops_W2022.Controllers
{
    public class MenuController : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        /// <summary>
        /// This controller takes in 4 parameters from 1 to 4, and calculates the amount of calories
        /// the 4 combined items have in total
        /// 
        /// Data for each list is stored in its own array, separating the drinks from the sides, etc
        /// 
        /// <example>
        /// Combining the list items:
        /// <param name="item1">2 (431)</param>
        /// <param name="item2">1 (130)</param>
        /// <param name="item3">3 (70)</param>
        /// <param name="item4">4 (0)</param>
        /// 
        /// <return>Your total calorie count is: 661</return>
        /// </example>
        /// </summary>
        {
            // the base output that will be returned, not including the totalCalories result
            string message = "Your total calorie count is: ";

            // arrays containing data for calories of each item on the menu
            int[] burgers = { 461, 431, 420, 0 };
            int[] drinks = { 130, 160, 118, 0 };
            int[] sides = { 100, 57, 70, 0 };
            int[] desserts = { 167, 266, 75, 0 };

            // defining a starting integer to combine everything in to.
            int totalCalories;

            /// the totalCalories is taking the number input by the user, and reducing it by one
            /// this is because the starting position in an array is 0
            /// the variable inside of the bracket is the index of the item in the array
            totalCalories = burgers[burger - 1] + drinks[drink - 1] + sides[side - 1] + desserts[dessert - 1];

            // finalized result
            message = message + totalCalories;

            return message;
        }
    }
}
