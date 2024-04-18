using nameSorterApp;
using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the path to the unsorted names file.");
                return;
            }

            var inputFilePath = args[0];
            var outputFilePath = "sorted-names-list.txt";

            try
            {
                var unsortedNames = File.ReadAllLines(inputFilePath);

                var nameSorter = new NameSorter(unsortedNames.ToList());
                nameSorter.Sort();

                Console.WriteLine("Sorted Names:");
                nameSorter.DisplaySortedNames();

                nameSorter.WriteToFile(outputFilePath);
                Console.WriteLine($"Sorted names have been written to {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
