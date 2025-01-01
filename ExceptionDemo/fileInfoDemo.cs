using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
   class fileInfoDemo
    {
        public void tryFileInfo()
        {
            FileInfo f;
            f = new FileInfo("C:\\Users\\rupesh.kumar\\Desktop\\.Net\\ExceptionDemo\\ExceptionDemo.sln");
            //f.CopyTo("C:\\Users\\rupesh.kumar\\Desktop\\FrontEnd\\fileDemo2.txt");
            long size = f.Length;
           DateTime d = f.CreationTime;
            DateTime d2 = f.LastAccessTime;
            DateTime d3 = f.LastWriteTime;
            string path=  f.FullName;
            string name =  f.Name;
            bool val = f.Exists;
            string ext = f.Extension;
            Console.WriteLine(f.DirectoryName); 
            Console.WriteLine(f.Attributes);
            Console.WriteLine(ext);
            Console.WriteLine(val);
            Console.WriteLine(name);
            Console.WriteLine(path);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
           
            Console.WriteLine(size);
            //Console.WriteLine("file Copied Successfully");
        }
    }
}
