using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1808
{
    class Collection
    {
        public void ExampleOfCollections()
        {
            SortedList ht = new SortedList();
            ht.Add(1, "Tom");
            ht.Add(2, "Jerry");
            ht.Add(3, "Rohan");
            ht.Add(4, "Ron");
            Console.WriteLine("Initial Sorted List");
            foreach(DictionaryEntry data in ht)
            {
                Console.WriteLine(data.Key+" "+data.Value);
            }
            ht.SetByIndex(3, "Rahul");
            Console.WriteLine("Updated List");
            foreach (DictionaryEntry data in ht)
            {
                Console.WriteLine(data.Key + " " + data.Value);
            }
            ht.RemoveAt(3);
            Console.WriteLine("After Deleting From List:");
            foreach (DictionaryEntry data in ht)
            {
                Console.WriteLine(data.Key + " " + data.Value);
            }
        }
    }
}
