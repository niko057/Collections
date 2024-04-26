using System.Collections;
using System.Diagnostics.Metrics;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomArray list = new CustomArray(3);
            list.Add("Nicat");
            list.Add("Namazov");
            list.Add(27);
            list.Remove(27);
            list.RemoveAt(1);
            //list.TrimToSize();
            //list.AddRange(new object[] { 0, 5 });
           

            Console.WriteLine($"Sayi: {list.Count}");
            Console.WriteLine($"Hecmi: {list.Capacity}");
            list.PrintAll();







        }
        
    }
}