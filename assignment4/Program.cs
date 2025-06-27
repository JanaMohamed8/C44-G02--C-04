
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace session4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1-1-three points and determines whether these points lie on a single straight line.
            //1- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3),
            //and determines whether these points lie on a single straight line.

            Console.WriteLine("Enter three points to determines whether these points lie on a single straight line. ");

            bool parsedX = false, parsedY = false;
            Point[] ArrPoints = new Point[3];

            for (int i = 0; i < 3; i++)
            {
                double x1, y2;
                do
                {
                    Console.WriteLine($"Please Enter Valid Point {i + 1} for x");
                    parsedX = double.TryParse(Console.ReadLine(), out x1);
                } while (!parsedX);

                do
                {
                    Console.WriteLine($"Please Enter Valid Point {i + 1} for y");
                    parsedY = double.TryParse(Console.ReadLine(), out y2);
                } while (!parsedY);

                if (parsedX && parsedY)
                {
                    Point point = new Point()
                    {
                        x = x1,
                        y = y2
                    };
                    ArrPoints[i] = point;
                }

            }
            //(y1- y0)*(x2-x1) == (y2-y1)*(x1-x0)
            if ((ArrPoints[1].y - ArrPoints[0].y) * (ArrPoints[2].x - ArrPoints[1].x) ==
             (ArrPoints[2].y - ArrPoints[1].y) * (ArrPoints[1].x - ArrPoints[0].x))
            {
                Console.WriteLine("These points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("These points does not lie on a single straight line.");
            }
            #endregion

            #region Q2-the efficiency of workers is evaluated based on the duration
            //2- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            //-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            Console.WriteLine("Enter the duration you required to complete a specific task to calculate your efficiency level.");
            bool parsed = false;
            double WorkHoursForTask;
            do
            {

                parsed = double.TryParse(Console.ReadLine(), out WorkHoursForTask);
                if (!parsed) Console.WriteLine("please enter valid Work Hours For Task");
            } while (!parsed);

            string outPut = WorkHoursForTask switch
            {
                >= 2 and <= 3 => "highly efficient",
                > 3 and <= 4 => "instructed to increase your speed",
                > 4 and <= 5 => "provided with training to enhance your speed",
                > 5 => "required to leave the company",
                _ => "Invalid input for hours task"
            };
            Console.WriteLine(outPut);


            #endregion

            #region Q3-20-sum of all elements of the array.
            //20- Write a program in C# Sharp to find the sum of all elements of the array.
            Console.WriteLine("Enter Number of Elements in array");
            bool parsedQ3 = false, flag = false;
            int sizeOfArr;

            do
            {
                parsedQ3 = int.TryParse(Console.ReadLine(), out sizeOfArr);
                if (!parsedQ3) Console.WriteLine("please enter valid size");
            } while (!parsedQ3);

            double[] arr = new double[sizeOfArr];

            for (int i = 0; i < sizeOfArr; i++)
            {
                Console.WriteLine($"Enter element {i + 1} ");
                double input;
                do
                {
                    flag = double.TryParse(Console.ReadLine(), out input);
                    if (!flag) Console.WriteLine("please enter valid input at array");
                } while (!flag);
                arr[i] = input;

            }
            Console.WriteLine($"Sum = {arr.Sum()}");
            #endregion


            #region Q4-21-merge two arrays of the same size sorted in ascending order.
            //21- Write a program in C# Sharp to merge two arrays of the same size sorted in
            //ascending order.


            double[] array1 = { 1, 5, 9 };
            double[] array2 = { 2, 6, 9 };
            int SizeOfMergedArray = array1.Length * 2;
            double[] MergedArray = new double[SizeOfMergedArray];
            int indexArr1 = 0, indexArr2 = 0;
            for (int i = 0; i < MergedArray.Length - 1; i++)
            {
                //

                if (array1[indexArr1] < array2[indexArr2])
                {
                    MergedArray[i] = array1[indexArr1];
                    indexArr1++;

                }
                // 2<1
                else if (array2[indexArr2] < array1[indexArr1])
                {
                    MergedArray[i] = array2[indexArr2];
                    indexArr2++;
                }
                //==
                else
                {
                    MergedArray[i] = array2[indexArr2];
                    i++;
                    MergedArray[i] = array1[indexArr1];
                    indexArr2++;
                    indexArr1++;
                }



            }

            for (int i = 0; i < MergedArray.Length; i++)
            {
                Console.WriteLine($"Element {i + 1} at Merged array = {MergedArray[i]}");
            }


            #endregion

            #region Q5- longest distance between Two equal cells.
            //write a program find the longest distance between Two equal cells.
            //In this example. 
            //The distance is measured by the number Of cells- for example, the distance between
            //the first and the fourth cell is 2 (cell 2 and cell 3).

            Console.WriteLine("Enter Number of Elements in array");
            bool parsedQ5 = false, flag1 = false;
            int sizeOfArray;

            do
            {
                parsedQ5 = int.TryParse(Console.ReadLine(), out sizeOfArray);
                if (!parsedQ5) Console.WriteLine("please enter valid size");
            } while (!parsedQ5);

            double[] array = new double[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine($"Enter element {i + 1} ");
                double number;
                do
                {
                    flag1 = double.TryParse(Console.ReadLine(), out number);
                    if (!flag1) Console.WriteLine("please enter valid input at array");
                } while (!flag1);
                array[i] = number;

            }

            int indexForSearched = -1, indexForfounded = -1;
            bool found = false;
            for (int i = 0; i < sizeOfArray; i++)
            {
                double searchForElement = array[i];
                for (int j = i + 1; j < sizeOfArray; j++)
                {
                    if (array[j] == searchForElement)
                    {
                        indexForfounded = j;
                        indexForSearched = i;
                        found = true;
                        break;
                    }

                }
                if (found)
                    break;
            }
            Console.WriteLine($"Number of Cells between frist number {array[indexForSearched]} with index {indexForSearched} Equal to the second number {array[indexForfounded]} with index {indexForfounded} is {indexForfounded - indexForSearched - 1}");
            #endregion


            #region Q6-26- Given a list of space separated words, reverse the order of the words.
            //26- Given a list of space separated words, reverse the order of the words.
            //Input: this is a test       Output: test a is this
            //Input: all your base        Output: base your all
            //Input: Word                 Output: Word
            //Note : 
            //Check the Split Function(Member in String Class) Output will be a Single
            //Console.WriteLine Statement

            Console.WriteLine("Enter list of space separated words to reverse the order of the words.");
            string? SpaceSeparatedWords=Console.ReadLine();

            //split => list of words
            //.reverse => reverse list
            // join => make reversed string from reversed list 
            string arrayString = string.Join (" ",SpaceSeparatedWords.Split(' ',StringSplitOptions.RemoveEmptyEntries).Reverse());
             
             Console.WriteLine(arrayString);




            #endregion
        }
        class Point
        {
            public double x;
            public double y;
        };
    }
}
