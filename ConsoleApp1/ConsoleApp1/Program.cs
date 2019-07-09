using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // var a = new InputNames();
           // a.Run();
           //new PlayWithStacks().Run();
        }
    }
    class Blueberry {
       
        public string StudentName;
        public string StudentNumber;
        public Blueberry link;
    }

    class Grapefruit
    {
        // grapefruit is the officemanager
        Blueberry Head;
        Blueberry Node;
        public void Run()
        {
            Head = new Blueberry();
            

            Node = new Blueberry();
            Node.StudentName = "joe";
            Node.StudentNumber = "A101";
            Head.link = Node;
        }
    }
    class InputNames
    {
        private static Queue<string> names;
        int counter = 0;

        public static Queue<string> GetQueue()
        {
            return names;
        }

        public void Run()
        {
            // how can I import a text file into a QUEUE data structure?
            // 1. get a HANDLE on the text file.

            // Read file using StreamReader. Reads file line by line  

            // string textFileName = "C:\Users\HP\Dropbox\Academic_Desk\ProgramCode\CSharpDataStructure\ConsoleApp1\ConsoleApp1";
            var fileStream = new FileStream(@"U:\Users\735275\kp\ConsoleApp1/name.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader file = new StreamReader(fileStream))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
    }
    class PlayWithStacks
    {

        static Stack<string> names;

        public void Run()
        {
            // how do I access the names in the names Queue?
            // how to GET ACCESS TO THE NAMES QUEUE??

            names = new Stack<string>();
            names.Push((InputNames.GetQueue()).Dequeue());
        }
    }
}
