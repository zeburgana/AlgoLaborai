using System;

namespace ConsoleApplication1
{
    internal static class Program
    {
        private static void Main()
        {
            const int countingSortCount = 4096;
            const int countingSortStep = 4;
            
            const int selectionSortCount = 1024;
            const int selectionSortStep = 2;
            
            var seed = (int) DateTime.Now.Ticks;
            var isRunning = true;

            PrintMenu();

            while (isRunning)
            {
                Console.Write("Enter operation number: ");

                switch (Console.ReadLine())
                {
                    case "help":
                        PrintMenu();
                        break;
                    case "1":
                        Sort.TestArrayRAM(selectionSortCount, selectionSortStep, seed, InsertionSort.Sort);
                        break;
                    case "2":
                        Sort.TestListRAM(selectionSortCount, selectionSortStep, seed, InsertionSort.Sort);
                        break;
                    case "3":
                        Sort.TestArrayRAM(countingSortCount, countingSortStep, seed, CountingSort.Sort);
                        break;
                    case "4":
                        Sort.TestListRAM(countingSortCount, countingSortStep, seed, CountingSort.Sort);
                        break;
                    case "6":
                        Sort.TestArrayDisk(selectionSortCount, selectionSortStep, seed, InsertionSort.Sort);
                        break;
                    case "7":
                        Sort.TestListDisk(selectionSortCount, selectionSortStep, seed, InsertionSort.Sort);
                        break;
                    case "8":
                        Sort.TestArrayDisk(countingSortCount, countingSortStep, seed, CountingSort.Sort);
                        break;
                    case "9":
                        Sort.TestListDisk(countingSortCount, countingSortStep, seed, CountingSort.Sort);
                        break;
                    case "11":
                        Sort.TestArrayRAM(selectionSortCount, selectionSortStep, seed, InsertionSort.Sort);
                        Sort.TestListRAM(selectionSortCount, selectionSortStep, seed, InsertionSort.Sort);
                        Sort.TestArrayRAM(countingSortCount, countingSortStep, seed, CountingSort.Sort);
                        Sort.TestListRAM(countingSortCount, countingSortStep, seed, CountingSort.Sort);
                        Sort.TestArrayDisk(selectionSortCount, selectionSortStep, seed, InsertionSort.Sort);
                        Sort.TestListDisk(selectionSortCount, selectionSortStep, seed, InsertionSort.Sort);
                        Sort.TestArrayDisk(countingSortCount, countingSortStep, seed, CountingSort.Sort);
                        Sort.TestListDisk(countingSortCount, countingSortStep, seed, CountingSort.Sort);
                        break;
                    case "x":
                        isRunning = false;
                        break;
                    default:
                        Console.Write("Invalid selection. ");
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Print this menu              help");
            Console.WriteLine("Tests from RAM:");
            Console.WriteLine("    Insertion sort of an array      1");
            Console.WriteLine("    Insertion sort of a list        2");
            Console.WriteLine("    Counting sort of an array      3");
            Console.WriteLine("    Counting sort of a list        4");
            Console.WriteLine("    Search in red-black tree        5");
            Console.WriteLine("Tests from disk:");
            Console.WriteLine("    Insertion sort of an array      6");
            Console.WriteLine("    Insertion sort of a list        7");
            Console.WriteLine("    Counting sort of an array      8");
            Console.WriteLine("    Counting sort of a list        9");
            Console.WriteLine("    Search in red-black tree       10");
            Console.WriteLine();
            Console.WriteLine("All of the above               11");
            Console.WriteLine("Exit                            x");
            Console.WriteLine();
        }
    }
}