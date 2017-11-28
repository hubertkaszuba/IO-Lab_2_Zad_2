using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace IO_Lab_2_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "file.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            IAsyncResult iar = fs.BeginRead(buffer, 0, buffer.Length, null, new object[] { fs, buffer });
            fs.EndRead(iar);

            string result = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            Console.WriteLine(result);
        }
    }
}
