using System;
using static System.Console;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will be your driving function that puts everything together

            //Welcome statement to the user
            WriteLine("Welcome to my various function calculator!\n");

            //I will let the user decide which function to use.
            while(true)
            {
                double function = (GetNumberFromUser("Press 1 if you would like to see if two numbers are close together.\nPress 2 if you would like to convert inches to centimeters.\nPress 3 if you would like to convert yards to meters.\nPress 4 if you would like to convert miles to kilometers.\nPress 0 to quit."));
                double E = 1e-4;
                switch(function)
                {
                    case 0:
                        return;
                    case 1:
                        double one = GetNumberFromUser("What numbers do you want to compare?");
                        double two = GetNumberFromUser("");
                        bool isit = IsClose(one, two);
                        if (isit == true)
                        {
                            WriteLine($"{one} is within {E} of {two}");
                        }
                        break;
                    case 2:
                        double inch = GetNumberFromUser("Please enter a number of inches to convert into centimeters");
                        string inch1 = "inches";
                        double cent = InchesToCentimeters(inch);
                        string cent1 = "centimeters";
                        WriteLine($"{DisplayNumberToConsole(inch, inch1)} is equal to {DisplayNumberToConsole(cent, cent1)}!");
                        break;
                    case 3:
                        double yard = GetNumberFromUser("Please enter a number of yards to convert into meters");
                        string yard1 = "yards";
                        double meter = YardsToMeters(yard);
                        string meter1 = "meters";
                        WriteLine($"{DisplayNumberToConsole(yard, yard1)} is equal to {DisplayNumberToConsole(meter, meter1)}!");
                        break;
                    case 4:
                        double mile = GetNumberFromUser("Please enter a number of miles to convert into kilometers");
                        string mile1 = "miles";
                        double kilometer = InchesToCentimeters(mile);
                        string kilometer1 = "kilometers";
                        WriteLine($"{DisplayNumberToConsole(mile, mile1)} is equal to {DisplayNumberToConsole(kilometer, kilometer1)}!");
                        break;
                }
            }

        }

        //make a function called IsClose that takes in two doubles and returns a bool
        public static bool IsClose(double firstIsClose, double secondIsClose)
            {
                //I am going to find the difference between my doubles. Then i will compare my differences in an if statement.
                double difference = Math.Abs(firstIsClose - secondIsClose);
                if(difference >= 1e-4)
                {
                    return false;  
                }
                else
                {
                    return true;
                }
            }

        //make a function called InchesToCentimeters that takes a double and returns a double
        public static double InchesToCentimeters(double inches)
            {
                //I am going to change the length into metric and then return my new value.
                double centimeters = (inches * 2.54);
                if (centimeters < 0)
                {
                    WriteLine("You cannot have a negative length, check your inputs.");
                    return centimeters;
                }
                else
                {
                    return centimeters;
                }
            }

        //make a function called YardsToMeters that takes in a double and returns a double
        public static double YardsToMeters(double yards)
            {
                //I am going to change the length into metric and then return my new value.
                double meters = (yards * 0.9144);
                if (meters < 0)
                {
                    WriteLine("You cannot have a negative length, check your inputs.");
                    return meters;
                }
                else
                {
                    return meters;
                }
            }

        //make a funciton called MilesToKilometers that takes in a double and returns a double
        public static double MilesToKilometers(double miles)
            {
                //I am going to change the length into metric and then return my new value.
                double kilometers = (miles * 1.609344);
                if (kilometers < 0)
                {
                    WriteLine("You cannot have a negative length, check your inputs.");
                    return kilometers;
                }
                else
                {
                    return kilometers;
                }
            }

        //make a function called GetNumberFromUser that takes in a message and returns the value the user inputs
        public static double GetNumberFromUser(string prompt)
        {
            //I will take in a prompt as a string, print it, and return a 
            WriteLine(prompt);
            double numbFromUser = double.Parse(ReadLine());
            return numbFromUser;
        }

        //make a function called DisplayNumberToConsole that takes in a double(the result) AND an output message and writes them out to the console
        public static string DisplayNumberToConsole(double measurement, string unit)
        {
            string output = ($"{measurement} {unit}");
            return output;
        }
    }
}
