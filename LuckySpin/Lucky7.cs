using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin
{
    public class Lucky7
    {
        public string Output() {
            //Get three random values
                Random random = new Random();
                int a = random.Next(1, 10);
                int b = random.Next(1, 10);
                int c = random.Next(1, 10);

            //Use the ternary operator ?: to assign a value to the image variable based a random 7
            string image = (a == 7 || b == 7 || c == 7) ?
                    "<img src='http://faculty.cascadia.edu/brianb/images/LuckySevenExercise.jpg'/>" :
                    ""; //empty string if none of the values are 7

            //Create the output String using the static method Format
            string output = String.Format(
                    "<button onclick='history.go(0)'>Spin</button>" +
                    "<div>{0}</div><div>{1}</div><div>{2}</div>" +
                    "<h1> Lucky Seven </h1>{3}", a, b, c, image);
            return output;
        }
    }
}
