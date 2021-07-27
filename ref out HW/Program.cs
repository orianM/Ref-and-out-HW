using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*1.ref - is a keyword that allows a variable to be modified by a method.
                out - is a keyword that demands a variable to be modified by a method.
             
              a. _Similarities_
                (1)Both ref and out can change a variable value in a method and keep the value out of the method.
                (2)Both ref and out are parameter modifiers.

              b. _Differences_
                (1)ref requires a variable with an already assigned value.
                (2)out does not require a variable with an already assigned value.*/

            #endregion

            #region question 2

            int numRef1 = 5;
            int numRef2 = 5;
            Console.WriteLine($"before function with ref parameter \nn1: {numRef1} \nn2: {numRef2}\n");

            RefFunction(ref numRef1, ref numRef2);

            Console.WriteLine($"after function with ref parameter \nn1: {numRef1} \nn2: {numRef2}");

            #endregion

            #region question 3

            int numOut1;
            int numOut2;
            OutFunction(out numOut1, out numOut2);
            Console.WriteLine($"\nout n1: {numOut1}, out n2: {numOut2}");

            #endregion

            #region question 4

            string error;
            ValidateValues("myFirst", "myLast", "53467235", "3457876435", 51, out error);
            Console.WriteLine(error);

            #endregion
        }

        /// <summary>
        /// Using ref
        /// Adds +1 to first int
        /// Multiplies second int by 2
        /// </summary>
        /// <param name="numRef1"></param>
        /// <param name="numRef2"></param>
        public static void RefFunction(ref int numRef1, ref int numRef2)
        {
            numRef1 = numRef1 + 1;
            numRef2 = numRef2 * 2;
        }

        /// <summary>
        /// Initializes variables using Out
        /// </summary>
        /// <param name="numOut1"></param>
        /// <param name="NumOut2"></param>
        public static void OutFunction(out int numOut1, out int NumOut2)
        {
            numOut1 = 1;
            NumOut2 = 2;
        }

        /// <summary>
        /// Validate values if properly inputted
        /// else, return error message
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="id"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public static bool ValidateValues(string firstName, string lastName, string phoneNumber, string id, int age, out string errorM)
        {
            errorM = "";
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                errorM = "First name or last name is null or empty";
            }
            if (phoneNumber[0] == '0' || phoneNumber.Length < 9)
            {
                errorM += "\nPhone number needs to begin with a zero";
            }
            if (id.Length != 9)
            {
                errorM += "\nId has to have exactly nine numbers";
            }
            if (age < 1 || age > 100)
            {
                errorM += "\nAge has to be between 1-100";
            }

            return string.IsNullOrEmpty(errorM);
        }
    }
}
