using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
namespace ValueTypeCollectionDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            TypeCollection<int> intCollection = new TypeCollection<int>();
            intCollection.AddItem(88);
            intCollection.AddItem(66);
            intCollection.AddItem(7);

            Console.WriteLine("Items in the collection:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(intCollection.GetItem(i));
            }

            Console.WriteLine("\nSorted collection in descending order:");
            var sortedList = intCollection.GetSortedDescending();
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }

}
