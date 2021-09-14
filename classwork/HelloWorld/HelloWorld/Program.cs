/*
 * file header
 * Your Name
 * ITSE 1430 Fall 2021
 */
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            static void DemoLogicalOperators()
                static void DemoRelationalOperators()
            {

                int x = 10, y = 20;

                bool isLessThan = x < y;
                bool isLessThanorEqualTo = x <=y;

                bool isGreaterThan = x > y;
                bool isGreaterThanOrEqualTo = x>= y;

                bool isEqual = x== y;
                bool isNotEqual = x != y;
            }

            static void DemoCombinationOperators()
            {
                //Works for more than just arithmetic
                int x = 10;
                x += 10; // x= x+ 10
                x -=20; // x= - 20
                x += 10; // x= x+ 10
                x += 10; // x= x+ 10
            }

            // Prefix increment
            // 1. Take current value of x and increment by 1
            // @. Store new value back in X
            // #. Expression value is current value of x
            y = ++x; //x = 11, y = 11

            // Prefix increment
            // 1. Take current value of x and increment by 1
            // @. Store new value back in X
            // #. Expression value is current value of x
            y = --x; //x = 10, y = 10

            // Postfix increment
            // 1. Take current value of x and increment by 1
            // @. Store new value back in X
            // #. Expression value is current value of x
            y = x++; //x = 11, y = 10

            // Postfix increment
            // 1. Take current value of x and increment by 1
            // @. Store new value back in X
            // #. Expression value is current value of x
            y = x--; //x = 10, y = 11


            //Logical And - true if both operands are true
            //Logical Or - true if either operand is true
            // X    Y   &&  ||
            // -----------------
            // F    F   F   F
            //F     T   F   T
            //T     F   F   T
            //T     T   T   T


            //NOT 
            //  F   !F =    T
            //  T   !T =    F
        }
        static void DemoAssignmentOperator()
        {
            int x;
            int y;
            int z;

            x = 10;
            y = 10;
            z = 10;

            //left associative (E1 op E2) => E1, E2, op
            // right associative operator (E1 op E2) => E2, e1, op
            x=y=z=20;// x = (y=(z=20))
        }
           
        static void Conditional Operator ()
        {
            int grade = 70;
            string passStatus;
            if (grade < 60)
                passStatus= "Not Passing";
            else
                passStatus = "Passing";
            //Terninary - operands
            //E(bool) ? E(True) : E(false)
           string passStatus2 =(grade<60) ? "Not Passing" : "Passing";

            static void DemoStrings()
            {
                string firstName = "Bob";
                //Relationals work, case sensitive
                bool isBob = firstName =="Bob";

                //String literals
                string literal1 = "Hello World";

                //Escape sequence - \?, only works in string literals
                // =>\n  newline
                // =>\t  horizontal tab
                // \\  slash
                // \"  double quote


                string filePath = "C:\\windows\\system32\\tasks";
                string verbatimFilePath = @"C:\windows\systems32\tasks";



                string quoteString = "Hello\"Bob\"";
                literal1 = "Hello\nWorld";

                //String length Length => how many characters
                int length = literal1.Length;

                //Empty string
                string emptyString = ""; // >length = 0
                string emptyString2 = String.Empty; // Lenghth =0
                bool areEmptyStringsEqual = String.Empty ==""; //True

                // null != empty string
                string nullString = null;
                bool areEqualNull

            }
                


        }
        }
    }
}
