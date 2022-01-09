using System;
using System.IO;


namespace Assignment5
{
    class Program
    {
        // declare any variabales that may be needed
        int total;
        int average;
        int max;
        int min;
        int median;
        
       

        static void Main(string[] args)
        {
            // Declare any varaibles
            int score;
            int index = 0;
            int elements = 0;
            int[] array = new int[45];

            // this will test to see if the file we want the exam scores is vaild 
            try
            {
                // read data from the text file
                StreamReader inputFile;
                inputFile = File.OpenText("Exam_scores.txt");

                // This while loop will run untill the end of the data
                while (index < array.Length && !inputFile.EndOfStream)
                {
                    // read data and store into the array 
                    array[index] = int.Parse(inputFile.ReadLine());
                    index++;
                    elements = array.Length;
                    
                }

                Console.WriteLine("The array is shown as follows: ");
                for (int i = 0; i < array.Length; i++)
                {

                    Console.Write(array[i] + " ");
                   
                }

                Program program = new Program();

                // display the methods
                Console.WriteLine("");
                Console.WriteLine("");
                program.Total(array);
                Console.WriteLine("");
                program.Average(array, elements);
                Console.WriteLine("");
                program.Max(array);
                Console.WriteLine("");
                program.Min(array);
                Console.WriteLine("");
                Console.WriteLine("The sorted array is: ");
                program.Sort(array);
                Console.WriteLine("");
                program.Median(array, elements);
                Console.ReadKey();


            }
            catch
            {
                Console.WriteLine("File not found");

            }
        }

        // Method gets the total of array's value 
        private void Total(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                total = total + array[i];
            }

            Console.WriteLine("The total of the array's value is: " + total);
        }

        // Method gets the average of the array's value 
        private void Average(int[] array, int elements)
        {
            average = total / elements;

            Console.WriteLine("The average of the array is: " + average);
        }

        // Method gets largets value in array  
        private void Max(int[] array)
        {
            int max = 50;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("The max value of the array is: " + max);
        }

        // Method gets the smallest value in array 
        private void Min(int[] array)
        {
            int min = 50;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine("The min value of the array is: " + min);
        }

        // Method sorts the array 
        private int[] Sort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1 + i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                
                Console.Write(array[i] + " ");
            }
            return array;
        }

        // Method that finds the middle value 
        private void Median(int[] array, int elements)
        {
            int middle = 0;
            int middle2;

            // Checks the median if array is odd or even
            if (array.Length % 2 == 1)
            {
                median = elements / 2;
                middle = array[median];
                Console.WriteLine("");
                Console.WriteLine("Median is: " + middle);

            }
            else
            {
                median = (array[elements / 2 - 1] + array[elements / 2]) / 2;
                middle = array[median];
                Console.WriteLine("");
                Console.WriteLine("Median is: " + middle);
            }

        }

        
    }
}
