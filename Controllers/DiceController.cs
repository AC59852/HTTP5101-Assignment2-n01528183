using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Loops_W2022.Controllers
{
    public class DiceController : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        /// <summary>
        /// This controller takes in 2 parameters, and looks to find how many
        /// times those 2 numbers can make the sum of 10.
        /// 
        /// If there is only one way, the message content will differ from if there are multiple ways,
        /// but the output number will always be the TOTAL amount of times to make 10
        /// 
        /// <example>
        /// Using 6 as the first die number, and 8 as the second
        /// <param name="number1">6</param>
        /// <param name="number2">8</param>
        /// 
        /// <return>There are 5 total ways to get the sum of 10</return>
        /// </example>
        /// </summary>

        {
            // dice start on the number 1
            int start = 1;

            // numbers and numbers2 are lists that hold each number before and including the user inputted number in the link
            List<int> numbers = new List<int>();
            List<int> numbers2 = new List<int>();

            // int for holding the total results for sum of 10
            int total = 0;

            // output declaration
            string message;

            // loop through the provided numbers and add them to separate lists
            for (int counter = start; counter <= m; counter++)
            {
                numbers.Add(counter);
            }

            for (int counter = start; counter <= n; counter++)
            {
                numbers2.Add(counter);
            }

            /// wrapping a foreach loop in another foreach loop
            /// this allows usage of the number integer inside of the second loop
            /// which then checks if the two numbers can be added to equal 10, if so, increment the counter by 1
            foreach (int number in numbers)
            {
                foreach (int number2 in numbers2)
                {
                    if (number + number2 == 10) total++;
                }
            }

            // if the total amount of combination of numbers equaling 10 only equals 1, change the output message slightly to reflect that.
            if (total == 1) message = "there is " + total + " way to get the sum of 10.";
            else message = "there are " + total + " total ways to get the sum of 10.";

            return message;
        }
    }
}
