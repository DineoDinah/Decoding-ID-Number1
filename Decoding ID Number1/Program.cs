using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding_ID_Number1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string IDNumber = "YYMMDDSSSSCAZ";
            if (IDNumber.Length != 13)
            {
                Console.WriteLine("ID Number is invalid.it should have 13 characters long.");
                return;
            }
            int year = int.Parse(IDNumber.Substring(0, 2));
            int month = int.Parse(IDNumber.Substring(2, 2));
            int day = int.Parse(IDNumber.Substring(4, 2));

            DateTime DateOfBirth = new DateTime(1900 + year, month, day);
            char GenderCode = IDNumber[6];

            string Gender = (GenderCode >= '0' && GenderCode <= '4') ? "Female" : "Male";

            char citizenship = IDNumber[10];
            string citizenshipStatus = (citizenship == '0') ? "SA Citizen" : "Permanent Resident";

            Console.WriteLine("Date Of Birth: " + DateOfBirth.ToShortDateString());
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("citizenship Status:" + citizenshipStatus);
            Console.ReadLine();
        }
    }
}
