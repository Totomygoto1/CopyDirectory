using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileCopy;

namespace FileCopy
{

    class DirectoryCopyExample
    {
        static void Main(string[] args)
        {
            FileCopyFacility cf = new FileCopyFacility();
            string set = "s";

            do 
            {
                Console.WriteLine("Please enter a file source path");
                string sourceDirName = Console.ReadLine();

                Console.WriteLine("Please enter a file destination path");
                string destDirName = Console.ReadLine();

                int result = cf.DirectoryCopy(@sourceDirName, @destDirName, true);

                if (result == 1)
                {
                    foreach (string s in cf._listFiles)
                    {
                        Console.WriteLine(s);
                    }
                }

                if (result == 0)
                {
                    Console.WriteLine("Please enter a file source path and destination path again ..");
                }

                Console.WriteLine("Please enter 'q' to quit or press 'Enter' to copy files .. ");
                set = Console.ReadLine();
            } 
            while (set != "q");

            Console.ReadKey();
        }


    }
}



