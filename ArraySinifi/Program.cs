﻿using System;

namespace ArraySinifi
{
    class Program
    {
        static void Main(string[] args)
        {
        //Sort
        int[] sayiDizisi={23,12,4,86,72,3,11,17};
        Console.WriteLine("*****Sırasız Dizi****");
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("*****Sıralı Dizi****");
        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Clear
        Console.WriteLine("*****Array Clear****");
        //sayiDizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı sıfırlar.
        Array.Clear(sayiDizisi,2,2);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Reverse
        Console.WriteLine("*****Array Reverse****");
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Index of
        Console.WriteLine("*****Array Index Of****");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));
        
        //Resize
        Console.WriteLine("*****Array Resize****");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8]=99;
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }


        }
    }
}
