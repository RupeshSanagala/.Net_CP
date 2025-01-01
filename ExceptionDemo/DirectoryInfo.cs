using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
   class DirectoryInfoDemo
    {
        public void tryDirectoryMethods()
        {
            DirectoryInfo d;
            d = new DirectoryInfo("C:\\Users\\rupesh.kumar\\Desktop\\FrontEnd");
            Console.WriteLine(d.FullName);
            Console.WriteLine(d.Name);
            Console.WriteLine(d.Parent);
            Console.WriteLine(d.CreationTime);
            Console.WriteLine(d.LastAccessTime);
            Console.WriteLine(d.LastWriteTime);
            Console.WriteLine(d.Root);
            Console.WriteLine(d.CreateSubdirectory("directoryDemo.txt"));

            //FileInfo[] files = d.GetFiles();
            DirectoryInfo[] files = d.GetDirectories();
            for (int i = 0; i < files.Length; i++)
            {

            Console.WriteLine(files[i].Name);
            }

           

        }
    }
}
