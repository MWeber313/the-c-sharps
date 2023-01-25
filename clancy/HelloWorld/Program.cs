using System;
 
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*          // use camelCase for local variables
            int number = 1;
            // use PascalCase for constants
            const int MaxZoom = 1;
            Console.WriteLine("Hello, World!");
            Console.WriteLine(number);
            Console.WriteLine(MaxZoom);
            byte biteboi = 255;
            Console.WriteLine(biteboi);

            uint a = uint.MaxValue;

            unchecked
            {
                Console.WriteLine(a + 1);  // output: 0
            }

            try
            {
                checked
                {
                    Console.WriteLine(a + 1);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
            }

            byte biteboi2 = 2;
            int count = 10;
            float totalPrice = 20.95f;
            // chars use single quotes ' '
            char character = 'A';
            // strings use double quotes " "
            string firstName = "Mack";
            bool isWorking = false;
            Console.WriteLine(biteboi2);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);


            // C SHARP HAS VARS

            var biteboi3 = 3;
            var count2 = 15;
            var totalPrice2 = 25.95f;
            var character2 = 'B';
            var lastName = "Weber";
            var isItWorking = true;

            Console.WriteLine(
                biteboi3 + "\n" +
                count2 + "\n" +
                totalPrice2 + "\n" +
                character2 + "\n" +
                lastName + "\n" +
                isItWorking
                );

            // THIS CAN BE DONE MUCH EASIER WITH FORMAT STRINGS

            Console.WriteLine("Format String Byte: {0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Format String Float: {0} {1}", float.MinValue, float.MaxValue);
            *//* 
            *** USING REAL NUMBERS ***
            When using real numbers, C# defaults to double,
            so if you want to declare a float or a decimal, you
            need to explicitly state it

            ex:

            float number = 1.2f;

            decimal number = 1.2m;

            WHAT DOES THIS MEAN?

            if I used

            float number = 1.2;

            the compiler would think it was a double, but put into
            a float (remember Java data types? C# has the same names,
            uncertain if there are any further similarities) 

             *//*

            // CHECKED keyword: handles overflowing

            *//*     
            checked
                {
                    byte bytenum = 255;
                    bytenum = bytenum + 1;
                }
            *//*

            // TYPE CONVERSION

            // implicit

            // compiler will convert type from one to the other if no data loss will occur with implicit conversion
            byte b = 1;
            int i = b;

            Console.WriteLine("Implicit type conversion: b:{0} i:{1}", b, i);

            // as we would lose 3 bytes of data, the following is not possible

            *//*
            int i2 = 1;

            byte b2 = i;
            */

            // explicit type conversion

            // casting tells the compiler that we are okay with data loss, and to go ahead with the conversion
            // place the type within parentheses that you wish to convert the variable to, followed by the variable
            float f = 1.0f;
            int i2 = (int) f;

            Console.WriteLine("Explicit type conversion: f(float):{0} i2(int):{1}", f, i2);

            int i3 = 300;
            byte b2 = (byte) i3;

            Console.WriteLine("Explicit type conversion with data loss: i3(int):{0} b2(byte):{1}", i3, b2);

            // type conversion between incompatible types but compatible data 
/*
            string s = "1234";
            int i4 = Convert.ToInt32(s);
            Console.WriteLine("Type conversion between incompatible types but compatible data: s(string):{0} i4(int):{1}", s, i4);*/

            // but what if you tried to convert string s to a byte? it would not work, it would cause an overflow exception (1234 is higher than the max value of 255 that a byte can hold)

            // so you have TRY AND CATCH: handle exceptions (like overflow from above)

            try
            {
                var s = "true";
                bool b = Convert.ToBoolean(s);
                var str = "true";
                /*bool d = (bool)str;*/
                // incompatible types! have to use convert class!
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("This number could not be converted to a Boolean");
            }



            int x= 5;
            int postY = x++;
            int preY = ++x;

            Console.WriteLine("x: {0}, Y, post of X: {1}, Y, pre of X: {2}", x, postY, preY);
        }
    }
}
