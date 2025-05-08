using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class AgeChecker
    {

        public void Check(String InputDate) {

            if (InputDate == null)
            {
                throw new ArgumentNullException(string.Empty);
            }

            DateTime CurrentDate = DateTime.Now;

            DateTime.TryParse(InputDate, out DateTime BirthDate);

            Console.WriteLine( "Current Date" + CurrentDate.ToString());

            Console.WriteLine("Birth Date" + BirthDate.ToString());

            

        }

        public void Input()
        {
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter day");
            int day = Convert.ToInt32(Console.ReadLine());

            string InputDate = $"{year}-{month:D2}-{day:D2}";

            Check(InputDate);
        }
    
    }
}
