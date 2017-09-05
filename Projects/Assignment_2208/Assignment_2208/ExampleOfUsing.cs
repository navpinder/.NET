using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_2208
{
    class ExampleOfUsing
    {
        public StreamWriter writer;
        public StreamReader reader;
        public void UsingsExample()
        {
            using (writer = new StreamWriter(new FileStream(@"C:\Users\singh_np\Documents\Visual Studio 2015\Projects\Assignment_2208\Assignment_2208\ExampleFile.txt", FileMode.Create)))
            {
                string hello = "Hello Hi its C# file mode";
                writer.WriteLine(hello);
                writer.Close();
            }
            string line = "";
            using (reader = new StreamReader(@"C:\Users\singh_np\Documents\Visual Studio 2015\Projects\Assignment_2208\Assignment_2208\ExampleFile.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
