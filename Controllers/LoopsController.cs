using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Loops_W2022.Controllers
{
    public class LoopsController : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            string message = "Your total calorie count is: ";
            int[] burgers = { 461, 431, 420, 0 };
            int[] drinks = { 461, 431, 420, 0 };
            int[] sides = { 461, 431, 420, 0 };
            int[] desserts = { 461, 431, 420, 0 };
            int totalCalories;

            totalCalories = burgers[burger-1] + drinks[drink-1] + sides[side-1] + desserts[dessert-1]; 
            message = message + totalCalories;

            return message;
        }

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string MyCounter(int m, int n)
        {
            int start = 1;
            List<int> numbers = new List<int>();
            List<int> numbers2 = new List<int>();
            int total = 0;
            string message = "";

            for (int counter = start; counter <= m; counter++)
            {
                numbers.Add(counter);
            }

            for (int counter = start; counter <= n; counter++)
            {
                numbers2.Add(counter);
            }

            foreach (int number in numbers)
            {
                foreach (int number2 in numbers2)
                {
                    if (number + number2 == 10) total++;
                }
            }

            if (total <= 1) message = "there is " + total + " way to get the sum of 10.";
            else message = "there are " + total + " total ways to get the sum of 10.";

            return message;
        }
    }
}
