using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_path = "";
            string file_path_extention = "";
            int duplicate_num = 0;

            
            //enter file path and parse it
            Console.WriteLine("please drug on my file and press enter");
            file_path = Console.ReadLine();
            if (file_path[0] == '"')
                file_path = file_path.Substring(1,file_path.Length-2);
            file_path_extention = new FileInfo(file_path).Extension;
            file_path = file_path.Substring(0,file_path.Length-file_path_extention.Length);
            //print result
            Console.WriteLine("entered: " + file_path);
            Console.WriteLine("entered: " + file_path_extention );
            //enter number of duplicates.
            Console.Write("please enter number of duplacates: ");
            duplicate_num = Int32.Parse(Console.ReadLine());
            //the duplicating proceess
            for (int i = 0; i < duplicate_num; i++)
            {
                Console.WriteLine("copying..number: " + (int)(i + 1));
                if (!(new FileInfo(file_path + (int)(i + 1) + file_path_extention).Exists))
                    File.Copy(file_path + file_path_extention, file_path + (int)(i + 1) + file_path_extention);
                Thread.Sleep(1000);
            }
        }
    }
}
