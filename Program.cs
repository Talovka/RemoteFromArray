using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number1 = rnd.Next(1, 50);
            int number2 = rnd.Next(50,100);
            Console.WriteLine($"Интервал({number1};{number2})");
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            InValue(ref arr,number1,number2);
            Console.Write("Новый массив: ");
            foreach (var item in arr) 
            {
                Console.Write($"{item} ");
            }
                
            }
        static public void InValue(ref int[] arr, int number1, int number2) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>number1&&arr[i]<number2) 
                {
                    InIndex(ref arr, i);
                    i--;
                }
            }
        }

        static public void InIndex(ref int[] data, int delIndex)
        {
            int[] newData = new int[data.Length - 1];
            for (int i = 0; i < delIndex; i++)
            {
                newData[i] = data[i];
            }
            for (int i = delIndex; i < newData.Length; i++)
            {
                newData[i] = data[i + 1];
            }
            data = newData;

        }

        }
    }

    

          

