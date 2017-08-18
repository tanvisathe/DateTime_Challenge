using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWork2_Date_Time
/*Write a C# console application to calculate the duration between two dates in Years, Months and Days. 
 * The user should enter two dates as input, then the program will show the result of the difference in time 
 * between these two dates. Show the difference in days, hours, and minutes.*/
{
    class Program
    {
        static void Main(string[] args)
        {

            //Taking two dates as input from the user
            Console.WriteLine("PLease Enter two dates to calculate duration between them");
            Console.WriteLine("Enter Date1 in format: YYYY-MM-DD");
            var biggerDate = Console.ReadLine();
            Console.WriteLine("Enter Date2 in format: YYYY-MM-DD");
            var smallerDate = Console.ReadLine();
           

            try
            {
                // Converting the string input dates into its DateTime equivalent
                DateTime date1 = DateTime.Parse(biggerDate);
                DateTime date2 = DateTime.Parse(smallerDate);
                //Check to make sure first date is always bigger than the second
                if (date1 < date2)
                {
                    Console.WriteLine("First date should be bigger than the second. Please try again");
                }
                else
                {
                    // Using TimeSpan to calculate total number of days, hours and minutes by subtracting two dates
                    TimeSpan timespan = date1.Subtract(date2);
                    Console.WriteLine("There are {0} number of days; {1} number of hours; {2} number of minutes, between {3} and {4}", timespan.TotalDays, timespan.TotalHours, timespan.TotalMinutes, date1.ToShortDateString(), date2.ToShortDateString());
                }
            }
            catch (Exception)
            {
                // If anything goes wrong while running this program the following message will be displayed
                Console.WriteLine("Oops.. something went wrong, please try again!");
            }

        }

        
    }
}
